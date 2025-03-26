using System;
using System.IO;
using System.Collections.Generic;

namespace JournalProgram
{
    class Journal
    {
        private List<Entry> _journalEntries = new List<Entry>();
        public List<string> _prompts = new List<string>
        {
            "What is one thing that you saw that reminded you of the Savior?",
            "Were you able to help someone in need today?",
            "What was the weather like today?",
            "What is one goal that you plan on starting next Monday?",
            "What is one special thing that you learned today?",
        };

        public void TypeEntry()
        {
            Random randomPrompt = new Random();
            string prompt = _prompts[randomPrompt.Next(_prompts.Count)];
            Console.WriteLine(prompt);
            Console.WriteLine();
            string response = Console.ReadLine();

            _journalEntries.Add(new Entry(response, prompt));
        }

        public void DisplayEntry()
        {
            Console.WriteLine("Your Journal Entries: ");
            foreach (var entry in _journalEntries)
            {
                Console.WriteLine($"- {entry.DisplayString()}");
            }
        }

        public void SaveEntry()
        {
            Console.WriteLine("Enter the name name of the file to save the journal entries: ");
            string fileName = Console.ReadLine();

            if (!fileName.EndsWith(".csv"))
            {
                fileName += ".csv";
            }

            using (StreamWriter write = new StreamWriter(fileName))
            {


                foreach (var entry in _journalEntries)
                {
                    write.WriteLine(entry.SaveString());
                }
            }
            Console.WriteLine("Your entries were saved! ");

        }
        public void LoadEntry()
        {
            Console.WriteLine("Enter the name of the file to load the journal entries: ");
            string fileName = Console.ReadLine();

            if (!fileName.EndsWith(".csv"))
            {
                fileName += ".csv";
            }

            if (File.Exists(fileName))
            {

                using (StreamReader read = new StreamReader(fileName))
                {
                    _journalEntries.Clear();
                    string line;
                    while ((line = read.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');

                        if (parts.Length == 3)
                        {
                            _journalEntries.Add(new Entry(parts[2].Trim(), parts[1].Trim()));
                        }
                    }
                }
                Console.WriteLine("Your entries were loaded! ");
                DisplayEntry();
            }

            else
            {
                Console.WriteLine("The file does not exist.");
            }
        }
    }
}