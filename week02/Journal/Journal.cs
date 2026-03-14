using System;
using System.Collections.Generic;
using System.IO;
using Journal;

namespace JournalApp;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        Console.WriteLine("Saving to file...");
        string filename = file;
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        Console.WriteLine("Loading from file...");
        string filename = file;
        if (!File.Exists(filename))
        {
            return;
        }
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            Entry entry = new Entry();
            string[] parts = line.Split(",");
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];
            
            _entries.Add(entry);
        }
    }
    
}