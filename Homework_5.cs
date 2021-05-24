using System;

namespace ConsoleApp8
{
    class Homework_5
    {
        static double[,] ReadImageDataFromFile(string imageDataFilePath)
        {
            string[] lines = System.IO.File.ReadAllLines(imageDataFilePath);
            int imageHeight = lines.Length;
            int imageWidth = lines[0].Split(',').Length;
            double[,] imageDataArray = new double[imageHeight, imageWidth];

            for (int i = 0; i < imageHeight; i++)
            {
                string[] items = lines[i].Split(',');
                for (int j = 0; j < imageWidth; j++)
                {
                    imageDataArray[i, j] = double.Parse(items[j]);
                }
            }
            return imageDataArray;
        }

        static void WriteImageDataToFile(string imageDataFilePath,double[,] imageDataArray)
        {
            string imageDataString = "";
            for (int i = 0; i < imageDataArray.GetLength(0); i++)
            {
                for (int j = 0; j < imageDataArray.GetLength(1) - 1; j++)
                {
                    imageDataString += imageDataArray[i, j] + ", ";
                }
                imageDataString += imageDataArray[i,imageDataArray.GetLength(1) - 1];
                imageDataString += "\n";
            }

            System.IO.File.WriteAllText(imageDataFilePath, imageDataString);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Insert image location :");
            string locateimage = Console.ReadLine();
            double[,] arrayimage = ReadImageDataFromFile(locateimage);
            double[,] newarrayimage = new double[7, 7];

            for (int i = 0; i < arrayimage.GetLength(0); i++)
            {
                for (int j = 0; j < arrayimage.GetLength(1); j++)
                {
                    newarrayimage[i + 1, j + 1] = arrayimage[i, j];
                }
            }

            newarrayimage[0, 1] = 160;
            newarrayimage[0, 2] = 64;
            newarrayimage[0, 3] = 16;
            newarrayimage[0, 6] = 160;
            newarrayimage[1, 0] = 32;
            newarrayimage[1, 6] = 64;
            newarrayimage[2, 0] = 160;
            newarrayimage[2, 6] = 192;
            newarrayimage[3, 0] = 16;
            newarrayimage[3, 6] = 128;
            newarrayimage[4, 6] = 32;
            newarrayimage[5, 6] = 160;
            newarrayimage[6, 0] = 32;
            newarrayimage[6, 1] = 64;
            newarrayimage[6, 3] = 128;
            newarrayimage[6, 4] = 64;
            newarrayimage[6, 5] = 32;
            newarrayimage[6, 6] = 64;

            Console.WriteLine("Insert convolution kernel location :");
            string locatekernel = Console.ReadLine();
            double[,] arraykernel = ReadImageDataFromFile(locatekernel);
            double[,] newarraykernel = new double[5, 5];

            Console.WriteLine("Insert result file location :");
            string locateoutput = Console.ReadLine();

            for (int i = 0; i < newarrayimage.GetLength(1) - arraykernel.GetLength(1) + 1; i++)
            {
                for (int j = 0; j < newarrayimage.GetLength(0) - arraykernel.GetLength(0) + 1; j++)
                {
                    double c = 0;
                    for (int k = 0; k < arraykernel.GetLength(1); k++)
                    {
                        for (int m = 0; m < arraykernel.GetLength(0); m++) {
                            c += newarrayimage[i + m, j + k] * arraykernel[m, k];
                        }
                    }
                    newarraykernel[i, j] = Math.Round(c,2);
                }
            }

            WriteImageDataToFile(locateoutput , newarraykernel);

            //ขอบคุณที่คอยคิดโจทย์มาสอนหนูนะคะ อันนี้เป็นการบ้านสุดท้ายที่หนูจะส่งแล้วเพราะย้ายที่เรียนแล้วค่ะ ขอบคุณมากเลยนะคับ ^_^
        }
    }
}