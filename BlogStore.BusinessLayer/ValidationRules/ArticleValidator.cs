using BlogStore.EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogStore.BusinessLayer.ValidationRules
{
    public class ArticleValidator : AbstractValidator<Article>
    {
        public ArticleValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Makale başlığı boş geçilemez").MinimumLength(10).WithMessage("Başlık en az 10 karakter olmalıdır.").MaximumLength(100).WithMessage("Başlık en fazla 100 karakter olmalıdır.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Makale içeriği boş geçilemez");
            RuleFor(x => x.CategoryId).LessThan(0).WithMessage("Katagori Id 0'dan küçük olamaz.");
        }
    }
}