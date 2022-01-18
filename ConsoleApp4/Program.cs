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




