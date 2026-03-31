using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction;
using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AIAnalyzers.ImageClasification
{
    
   
    class FlowerClascification
    {
        private static string predictionEndpoint = "https://eastus.api.cognitive.microsoft.com/";
        private static string predictionKey = "";

        public FlowerClascification()
        {
            
        }
        
        private static CustomVisionPredictionClient AuthenticatePrediction(string endpoint, string predictionKey)
        {
            // Create a prediction endpoint, passing in the obtained prediction key
            CustomVisionPredictionClient predictionApi = new CustomVisionPredictionClient(new Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction.ApiKeyServiceClientCredentials(predictionKey))
            {
                Endpoint = endpoint
            };
            return predictionApi;
        }
        
        
        public async Task TestIteration()
        {
            var client = AuthenticatePrediction(predictionEndpoint, predictionKey);
            var projectid = new Guid("");
            var imageUrl =new ImageUrl("https://plus.unsplash.com/premium_photo-1721317368393-09204f05aab5?q=80&w=1170&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D");
            var publishedName = "Iteration4";
            var predictions = await client.ClassifyImageUrlAsync(projectid, publishedName, imageUrl);
            foreach (var tag in predictions.Predictions)
                Console.WriteLine($"{tag.TagName} - {tag.Probability}");
        }
        
    }
    
}
