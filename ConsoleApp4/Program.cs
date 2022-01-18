// See https://aka.ms/new-console-template for more information
using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction;
using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Training;
using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Training.Models;
using System;
using OpenCvSharp;

namespace ConsoleApp4
{
    internal class Program
    {

        private static string modelAPI = "https://visionoppgave-prediction.cognitiveservices.azure.com/customvision/v3.0/Prediction/d2266057-b9f2-4d8e-a4a8-14fe78ac2edc/detect/iterations/BallModel1/image";
        private static string predictionEndpoint = "https://visionoppgave-prediction.cognitiveservices.azure.com/";
        private static string predictionKey = "33e8276cbca445e193a916f549e95b2d";
        private static string predictionResourceId = "/subscriptions/f417f081-089c-4c18-a54b-16aac0203a3c/resourceGroups/Hjemme-nettverk/providers/Microsoft.CognitiveServices/accounts/Visionoppgave";
        private static string trainingEndpoint = "https://visionoppgave.cognitiveservices.azure.com/";
        private static string trainingKey = "987f7ea480f54f72929f0599704562d0";

       
        private static string publishedModelName = "BallModel5"; //Denne finner vi under performace/iteration n/publish (Vi velger navn når vi publisher)
        static string projectID = "d2266057-b9f2-4d8e-a4a8-14fe78ac2edc";
        static public string[] ball = new string[20];

        static void Main(string[] args)
        {
            
            Ball_detaction det = new Ball_detaction();
            ball = det.TestIteration();
            for (int i = 0; i < ball.GetUpperBound(0); i++)
            {
                Console.WriteLine(ball[i]);

            // Make a prediction against the new project
            Console.WriteLine("Please provide path for the image");
            string imageLocation = Console.ReadLine();
            var imageFile = imageLocation;
            Console.WriteLine("Making a prediction:");
            using (var stream = File.OpenRead(imageFile))
            {
                var result = predictionApi.DetectImage(project.Id, publishedModelName, stream);

                // Loop over each prediction and write out the results
                foreach (var c in result.Predictions)
                {
                    Console.WriteLine($"\t{c.TagName}: {c.Probability:P1} [ {c.BoundingBox.Left}, {c.BoundingBox.Top}, {c.BoundingBox.Width}, {c.BoundingBox.Height} ]");
                }
            }
            Console.ReadKey();
        }
        static private CustomVisionTrainingClient AuthenticateTraining(string endpoint, string trainingKey, string predictionKey)
        {
            // Create the Api, passing in the training key
            CustomVisionTrainingClient trainingApi = new CustomVisionTrainingClient(new Microsoft.Azure.CognitiveServices.Vision.CustomVision.Training.ApiKeyServiceClientCredentials(trainingKey))
            {
                Endpoint = endpoint
            };
            return trainingApi;
        }
        static private CustomVisionPredictionClient AuthenticatePrediction(string endpoint, string predictionKey)
        {
            // Create a prediction endpoint, passing in the obtained prediction key
            CustomVisionPredictionClient predictionApi = new CustomVisionPredictionClient(new Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction.ApiKeyServiceClientCredentials(predictionKey))
            {
                Endpoint = endpoint
            };
            return predictionApi;
        }

       


    }
}




