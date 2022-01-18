// See https://aka.ms/new-console-template for more information
using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction;
using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Training;
using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Training.Models;
using System;

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

            }
            
        }

       


    }
}




