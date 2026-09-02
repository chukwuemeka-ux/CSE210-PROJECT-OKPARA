// Creative Feature:
// This program displays the total number of journal entries
// whenever the journal is displayed.
// It also prevents the program from crashing if the user
// tries to load a file that does not exist.

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("\nWelcome to the Journal Program!");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Please enter a number from 1 to 5.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("> ");

                    Entry entry = new Entry();
                    entry._promptText = prompt;
                    entry._entryText = Console.ReadLine();
                    entry._date = DateTime.Now.ToShortDateString();

                    journal.AddEntry(entry);
                    break;

                case 2:
                    journal.DisplayAll();
                    break;

                case 3:
                    Console.Write("Enter filename: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;

                case 4:
                    Console.Write("Enter filename: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case 5:
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please choose 1-5.");
                    break;
            }
        }
    }
}