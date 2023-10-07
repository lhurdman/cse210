using System;

class Journal
{
    // Lists to keep the entries and the prompts.
    private List<Entry> entries;
    private List<string> prompts;

    // Function that holds the lists.
    public Journal()
    {
        entries = new List<Entry>();
        prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What have I unlearned recently?",
            "Who is inspiring me right not?",
            "How can I incorporate more moments of savoring into my daily life?",
            "What books am I truly grateful for?"
        };
    }

    // Function that adds entries.
    public void AddEntry()
    {
        Random random = new Random();
        string randomPrompt = prompts[random.Next(prompts.Count)];

        DateTime currentDate = DateTime.Now;

        Console.WriteLine($"Prompt: {randomPrompt}");

        Console.Write("Enter your response: ");
        string response = Console.ReadLine();

        // New thing that I added for creativity and exceeding requirements :)
        Console.WriteLine($"What are you grateful for today? ");
        string grateful_response = Console.ReadLine();

        // This gets added into the Entry Class.
        entries.Add(new Entry
        {
            Prompt = randomPrompt,
            Response = response,
            Grateful = grateful_response,
            // Change the date to a string.
            Date = currentDate.ToString("MM/dd/yyyy")
        });
    }

    // Function that displays the entries.
    public void DisplayEntries()
    {
        Console.WriteLine("Journal Entries:");
        // This is pulling from the Entry File.
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}");
            Console.WriteLine($"Grateful: {entry.Grateful}");
            Console.WriteLine();
        }
    }

    // Function that saves the entries to a file.
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            // This is also pulling from the Entry File.
            foreach (var entry in entries)
            {
                writer.WriteLine($"Date: {entry.Date}");
                writer.WriteLine($"Prompt: {entry.Prompt}");
                writer.WriteLine($"Response: {entry.Response}");
                writer.WriteLine($"Grateful: {entry.Grateful}");
                writer.WriteLine();
            }
        }
        Console.WriteLine("Journal saved to file successfully!");
    }

    // Function that loads the entries from a file.
    public void LoadFromFile(string filename)
    {

        using (StreamReader reader = new StreamReader(filename))
        {
            Entry currentEntry = null;
            while (!reader.EndOfStream) // Comes from StreamReader.
            {
                // These are things that every Entry should have.
                string line = reader.ReadLine();
                if (line.StartsWith("Date: "))
                {
                    currentEntry = new Entry();
                    currentEntry.Date = line.Substring(6);
                }
                else if (line.StartsWith("Prompt: "))
                {
                    currentEntry.Prompt = line.Substring(8);
                }
                else if (line.StartsWith("Response: "))
                {
                    currentEntry.Response = line.Substring(10);
                    entries.Add(currentEntry);
                }
                else if (line.StartsWith("Grateful: "))
                {
                    currentEntry.Grateful = line.Substring(12);
                }
            }
        }
        Console.WriteLine("Journal loaded successfully!");
    }
}