/*
Author: Team SPAM Jeremiah Powell, Angelo Arellano Gaona, Jeffrey Meldrum, 
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
    Console.WriteLine($"\n{_prompt}");
    Console.WriteLine($"{_response}");
    Console.WriteLine($"{_date}");
  }

  public void SpamSaveEntry(String _spamPrompt, String _spamResponse, DateTime _spamDate)
  {
    _prompt = _spamPrompt;
    _response = _spamResponse;
    _date = _spamDate;
  }
}