using BlogStore.BusinessLayer.Abstract;
using BlogStore.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlogStore.PresentationLayer.Controllers
{
    [Route("[controller]/[action]")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IToxicityDetectionService _toxicityDetectionService;
        private readonly ITranslationService _translationService;

        public CommentController(ICommentService commentService, UserManager<AppUser> userManager, IToxicityDetectionService toxicityDetectionService, ITranslationService translationService)
        {
            _commentService = commentService;
            _userManager = userManager;
            _toxicityDetectionService = toxicityDetectionService;
            _translationService = translationService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateComment(Comment comment)
        {
            try
            {
                if (comment == null || string.IsNullOrWhiteSpace(comment.CommentDetail))
                    return Json(new { status = "error", message = "Yorum verisi eksik veya geçersiz." });

                var translatedCommentDetail = await _translationService.TranslateToEnglishAsync(comment.CommentDetail)
                                            ?? comment.CommentDetail;

                var detectionResult = await _toxicityDetectionService.DetectToxicityAsync(translatedCommentDetail);

                comment.IsToxic = detectionResult.IsToxic;
                comment.ToxicityScore = (float)detectionResult.Score;
                comment.AppUserId = _userManager.GetUserId(User);
                comment.UserNameSurname = _userManager.GetUserName(User);
                comment.CommentDate = DateTime.Now;

                if (detectionResult.IsToxic)
                {
                    return Json(new { status = "toxic", message = "Paylaşımınızda topluluk kurallarımıza uygun olmayan ifadeler tespit edildiği için yorumunuz işleme alınamadı." });
                }

                _commentService.TInsert(comment);

                return Json(new { status = "success", message = "Yorumunuz başarıyla eklendi." });
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.Message ?? "No inner exception";
                return Json(new { success = false, message = "Bir hata oluştu: " + ex.Message + " | Inner: " + inner });
            }
        }


        [HttpGet]
        public IActionResult CommentList()
        {
            var values = _commentService.TGetAll();
            return View(values);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> TestToxicity(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return Json(new { success = false, message = "Metin boş olamaz." });

            try
            {
                var translated = await _translationService.TranslateToEnglishAsync(text)
                                  ?? text; 

                var result = await _toxicityDetectionService.DetectToxicityAsync(translated);

                return Json(new
                {
                    success = true,
                    input = text,
                    translated = translated,
                    isToxic = result.IsToxic,
                    score = result.Score,
                    detectedLabel = result.DetectedLabel
                });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }
    }
}