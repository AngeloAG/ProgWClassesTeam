/*
Author: Team SPAM
Description:
Responsibilities: Creates entries 
for the journal class to keep track 
of. 
Attributes: it will have the 
prompts, dates and response 
given by the user.
Behaviors: It's a list that will keep 
the entries and display the 
information.
*/
using System;
public class SpamEntry
{
  public String _prompt;
  public String _response;
  public DateTime _date;

   public SpamEntry()
  {

  }

  public void SpamDisplay()
  {
    Console.WriteLine($"{_prompt}");
    Console.WriteLine($"{_response}");
    Console.WriteLine($"{_date}");
  }

  public void SpamSaveEntry(String spamPrompt, String spamResponse, DateTime spamDate)
  {
    _prompt = spamPrompt;
    _response = spamResponse;
    _date = spamDate;
  }
}