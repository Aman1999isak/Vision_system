// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.ReadLine();

string modelAPI = "https://visionoppgave-prediction.cognitiveservices.azure.com/customvision/v3.0/Prediction/d2266057-b9f2-4d8e-a4a8-14fe78ac2edc/detect/iterations/BallModel1/image";
string predictionEndpoint = "https://visionoppgave-prediction.cognitiveservices.azure.com/";
string predictionKey = "33e8276cbca445e193a916f549e95b2d";
// You can obtain this value from the Properties page for your Custom Vision Prediction resource in the Azure Portal. See the "Resource ID" field. This typically has a value such as:
// /subscriptions/<your subscription ID>/resourceGroups/<your resource group>/providers/Microsoft.CognitiveServices/accounts/<your Custom Vision prediction resource name>
private static string predictionResourceId = "/subscriptions/f417f081-089c-4c18-a54b-16aac0203a3c/resourceGroups/Hjemme-nettverk/providers/Microsoft.CognitiveServices/accounts/Visionoppgave";
