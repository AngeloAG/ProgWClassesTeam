/*
Author: Team SPAM
Description:
Responsibilities: It generates a list 
of entries from the entry class
Attributes: A list style of all user 
entered journal entries. 
Behaviors: It will be a class that 
will track and hold all the entries 
put in by the user, display them, 
saving them to a file and load them 
from a file
*/
using System.IO;

public class SpamJournal
{
  /*TODO implement attributes to hold the list of entries*/
  List<SpamEntry> _entries;

  public SpamJournal()
  {
    _entries = new List<SpamEntry>();
  }

  public void SpamDisplay()
  {
    /*TODO implement method to show the list of entries*/
    foreach (SpamEntry entry in _entries)
    {
      entry.SpamDisplay();
    }
  }

  public void SpamLoadFromFile(String spamFilePath)
  {
    /*TODO implement method to load file of entries into the attribute list of entries*/
    string[] spamLines = System.IO.File.ReadAllLines(spamFilePath);

    _entries.Clear();

    SpamEntry spamNewEntry = new SpamEntry();

    foreach (string line in spamLines)
    {
      string[] spamparts = line.Split(",");

      string spamPrompt = spamparts[0];
      string spamResponse = spamparts[1];
      string spamDateString = spamparts[2];
      DateTime spamDate = DateTime.Parse(spamDateString);

      spamNewEntry.SpamSaveEntry(spamPrompt, spamResponse, spamDate);

      _entries.Add(spamNewEntry);
      Console.WriteLine("Success!! File Loaded");
    }
  }

  public void SpamSaveToFile(String spamFilePath)
  {
    /*TODO implement method to save the current list of entries to a file*/
    using (StreamWriter spamOutputFile = new StreamWriter(spamFilePath))
    {
      foreach (SpamEntry entry in _entries)
      {
        spamOutputFile.WriteLine($"{entry._prompt},{entry._response},{entry._date.ToShortDateString()}");
      }
    }
    Console.WriteLine("Success!! New File Created");
  }

  public void SpamWriteNewEntry(String spamPrompt)
  {
    /*TODO implement method to add a new entry to the list of entries*/
    String spamUserResponse = Console.ReadLine();
    DateTime spamCurrentDate = DateTime.Now;
    SpamEntry spamNewEntry = new SpamEntry();

    spamNewEntry.SpamSaveEntry(spamPrompt, spamUserResponse, spamCurrentDate);
    _entries.Add(spamNewEntry);
  }
}