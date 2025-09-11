using BlogStore.BusinessLayer.Abstract;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BlogStore.BusinessLayer.Concrete
{
    public class ToxicityManager : IToxicityDetectionService
    {
        private readonly HttpClient _httpClient;
        private readonly string _huggingFaceApiToken;
        private readonly string _huggingFaceModelUrl;

        public ToxicityManager(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _huggingFaceApiToken = configuration["HuggingFaceToxicity:ApiToken"];
            _huggingFaceModelUrl = configuration["HuggingFaceToxicity:ModelUrl"];

            _httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", _huggingFaceApiToken);
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<ToxicityDetectionResult> DetectToxicityAsync(string commentText)
        {
            if (string.IsNullOrWhiteSpace(commentText))
                return new ToxicityDetectionResult { IsToxic = false, Score = 0, DetectedLabel = "undetected" };

            var requestBody = new { inputs = commentText };
            var jsonContent = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_huggingFaceModelUrl, jsonContent);

            if (!response.IsSuccessStatusCode)
                return new ToxicityDetectionResult { IsToxic = false, Score = 0, DetectedLabel = "undetected" };

            var responseString = await response.Content.ReadAsStringAsync();
            System.Diagnostics.Debug.WriteLine("Toxicity Model Response: " + responseString);

            var modelResponse = JsonConvert.DeserializeObject<List<List<ModelPrediction>>>(responseString);
            var topPrediction = modelResponse?[0]?.OrderByDescending(p => p.Score).FirstOrDefault();

            if (topPrediction == null)
                return new ToxicityDetectionResult { IsToxic = false, Score = 0, DetectedLabel = "undetected" };

            var toxicLabels = new[] { "toxic", "insult", "obscene", "hate", "offensive", "threat" };
            bool isToxic = toxicLabels.Any(l => topPrediction.Label.ToLower().Contains(l));

            return new ToxicityDetectionResult
            {
                IsToxic = isToxic && topPrediction.Score > 0.25, // düşük threshold
                Score = topPrediction.Score,
                DetectedLabel = topPrediction.Label
            };
        }

        private class ModelPrediction
        {
            public string Label { get; set; }
            public double Score { get; set; }
        }
    }
}
