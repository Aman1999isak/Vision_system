using OpenCvSharp;
namespace ConsoleApp4
{
    public class Camera
    {
        static private void BallisMoving()
        {
            //Ref:https://elbruno.com/2020/11/11/dotnet-20-lines-to-display-a-webcam-camera-feed-with-python-using-opencv/
            //This method should check if the balls are in motion or not.
            var capture = new VideoCapture(0);
            var window = new Window("Camtest");
            var image = new Mat();
            while (true)
            {
                capture.Read(image);
                if (image.Empty())
                    break;
                window.ShowImage(image);
                if (Cv2.WaitKey(1) == 113) // Q
                    break;
            }
            Console.WriteLine("Image taken");


        }
    }
}