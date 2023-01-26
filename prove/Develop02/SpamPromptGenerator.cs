/*
Author: Team SPAM Jeremiah Powell, Angelo Arellano Gaona, Jeffrey Meldrum, 
Description:
Responsibilities: It generates a 
random prompt from a list.
Attributes: A list that is going to 
hold random prompts.
Behaviors: Choose a random 
prompt and give it back.
*/
using System;

public class SpamPromptGenerator
{
  /*TODO create attributes to store the list of prompts*/

  public SpamPromptGenerator()
  {

  }

  public String SpamGetRandomPrompt()
  {
    /*TODO Implement the method to pick a prompt from the list and return it*/
    List<string> spamPromptList = new List<string>();
    spamPromptList.Add("What was the best part of your day?");
    spamPromptList.Add("What is something new you learned today?");
    spamPromptList.Add("What is something fun you did today?");
    spamPromptList.Add("How was the weather today?");
    spamPromptList.Add("What was your favorite meal today?");

    Random spamRandomPromptNumber = new Random();
    int spamListIndex = spamRandomPromptNumber.Next(0, 4);
    string spamRandomPrompt = spamPromptList[spamListIndex];
    return spamRandomPrompt;
  }
}