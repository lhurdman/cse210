using System;
using System.Collections.Generic;
using System.IO;

/* 
Name: My Journal
Purpose: To create a program that people can use to save their journal entries.
There are prompts and a place to put what you are grateful for so that people
are more likly to write in the journal.
Author: Lindsay Hurdman,
(ChatGTP to tell me why I was getting errors and what some errors ment)
Date: (c) 2023
*/

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        while (true) // Main loop for the menu
        {
            Console.WriteLine("Journal App Menu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            if (choice == "1") // Add Entry
            {
                journal.AddEntry();
            }
            else if (choice == "2") // Display Entries
            {
                journal.DisplayEntries();
            }
            else if (choice == "3") // Load from File
            {
                Console.Write("What is the file name you want to load? ");
                string loadFileName = Console.ReadLine();
                journal.LoadFromFile(loadFileName);
            }
            else if (choice == "4") // Save to File
            {
                Console.Write("What is the file name you want to save? ");
                string saveFileName = Console.ReadLine();
                journal.SaveToFile(saveFileName);
            }

            else if (choice == "5") // Exit
            {
                //false;
                break; // Exit the loop to end the program
            }
            else
            {
                Console.WriteLine("Invalid choice. Please choose a number between 1-5.");
            }
        }
    }
}
