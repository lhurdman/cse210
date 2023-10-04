using MyJournal;
using MyEntry;
using System.IO;

/* 
Name: My Journal
Purpose: <find in assinment>
Author: <classmates>
Date: (c) 2023
*/

class Program
{
    static void Main(string[] args) 
    {
        Console.WriteLine("Welcome to the Journal!");
        Console.Write("1. Display \n2.Write Entry \n3.Save \n4.Load \n5.Display \n6.Quit\n");
        string decision = Console.ReadLine();

        if (decision == "1") {
            string filename = "myFile.txt";
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");

                string firstName = parts[0];
                string lastName = parts[1];
            } 
        }
        else if (decision == "2") 
        {
            string fileName = "myFile.txt";

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                // You can add text to the file with the WriteLine method
                outputFile.WriteLine("This will be the first line in the file.");
                
                // You can use the $ and include variables just like with Console.WriteLine
                string color = "Blue";
                outputFile.WriteLine($"My favorite color is {color}");
            }
            // Entry entry1 = new Entry();
            // Console.WriteLine("Write Your Entry.");
            // string _entry = Console.ReadLine();

        }
        else if (decision == "3") 
        {
            // Save
        }
        else if (decision == "4") 
        {
            // Load
        }
        else if (decision == "6") 
        {
            // Quit
        }

        Journal journal1 = new Journal();
    }
}