using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    // Add a new journal entry
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Display all entries
    public void DisplayAll()
    {
        Console.WriteLine($"\nTotal Entries: {_entries.Count}\n");

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Save entries to a file
    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }

        Console.WriteLine("Journal saved successfully!");
    }

    // Load entries from a file
    public void LoadFromFile(string fileName)
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();

        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];

            _entries.Add(entry);
        }

        Console.WriteLine("Journal loaded successfully!");
    }
}