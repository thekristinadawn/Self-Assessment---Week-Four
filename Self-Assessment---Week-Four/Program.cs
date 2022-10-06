using System;
using System.IO;
using System.Net;

namespace Self_Assessment___Week_Four
{
    internal class Program
    {
        //Comment out other exercises to run each individually

        //Exercise 7 -- Positive Sqrt -- COMPLETED
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a positive integer.");
            int inputInteger = Convert.ToInt32(Console.ReadLine());

            if (inputInteger % 2 == 0)
            {
                Console.WriteLine(Math.Sqrt(inputInteger));
                Console.WriteLine("Good Bye");

            }
            else
            {
                Console.WriteLine("Invalid Number.");
                Console.WriteLine("Good Bye");
            }

        }

        //Exercise 8 -- Write a method ReadNumber(int start, int end)  -- COMPLETED

        static string ReadNumber(int start, int end)
        {
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            if (inputNumber < start || inputNumber > end)
                return "Invalid Number";
            else
                return "Valid Number";
        }

        static void Main(string[] args)
        {
            string result = ReadNumber(7, 11);
            Console.WriteLine(result);
        }

        //Exercise 9 -- method that takes as a parameter the name of a text file, reads the file, and returns its content as string. What should the method do if an exception is thrown? -- -- COMPLETED

            static void ReadFile(string fileName)
        {
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string text;
                    while ((text = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(text);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("The file could not be read.");
            }
            Console.ReadKey();
        }

        static void Main()
        {
            ReadFile(@"C:\Users\Kristina.Palmer\Documents\mbox-short.txt");
        }

        //Exercise 13 -- Write a program to download a file from Internet by a given URL -- COMPLETED

        static void Main()
        {
            try
            {
                Console.WriteLine("Please enter URL:");
                string url1 = Console.ReadLine();                  //
                string savePath1 = @"X:\Operations Analysis\Kristina Palmer\downloadimage.jpg";
                WebClient client1 = new WebClient();
                client1.DownloadFile(url1, savePath1);
                Console.ReadLine();
                
                
            }
            catch (Exception)
            {
                Console.WriteLine("Could not save.");
            }

            //https://introprogramming.info/wp-content/uploads/2017/08/csharp-book-nakov-en-v2013-cover.jpg
            //http://introprogramming.info/wp-content/themes/introprograming_en/images/Intro-Csharp-Book-front-cover-big_en.png
           
        }

    }
}
