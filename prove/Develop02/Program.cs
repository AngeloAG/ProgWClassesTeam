/*
Author: Team SPAM
Description:
Responsibilities:
It runs the main function and 
keeps showing the menu and 
handling the uesr input.
Attributes:
A journal instance that will hold 
the entries of the user.
A promptGenerator instance that 
will be used to get random 
prompts.
A menu instance that will show the 
options and record the user input
Behaviors:
It runs the main function in a loop 
until the user wants to exit the 
program.  It will close the program 
as well.
*/

using System;

class Program
{
  /*TODO implement attributes to store the jorunal instance, promptGenerator instance, and menu instance*/
  static void Main(string[] args)
  {
    Console.WriteLine("Welcome to the Journal Program");
    bool spamContinueAsking = true;

    SpamPromptGenerator spamPromptGenerator = new SpamPromptGenerator();
    SpamMenu spamMenu = new SpamMenu();
    SpamJournal spamJournal = new SpamJournal();

    do
    {
      Console.WriteLine("\nWhat do you want to do?");
      spamMenu.SpamDisplayMenu();
      string spamUserSelection = spamMenu.SpamAskForMenuSelection();

      switch (spamUserSelection)
      {
        case "1":
          //Option to write a new entry
          string prompt = spamPromptGenerator.SpamGetRandomPrompt();
          Console.WriteLine(prompt);
          spamJournal.SpamWriteNewEntry(prompt);
          break;
        case "2":
          //Option to Display the entries
          spamJournal.SpamDisplay();
          break;
        case "3":
          //Option to Load entries from file
          try
          {
            Console.Write("Please enter the new name for the file: ");
            string spamFileName = Console.ReadLine();
            spamJournal.SpamLoadFromFile(spamFileName);
          }
          catch (Exception e)
          {
            Console.WriteLine($"Error {e}");
          }
          break;
        case "4":
          //Option to Save entries from file
          try
          {
            Console.Write("Please enter the new name for the file: ");
            string spamSaveFileName = Console.ReadLine();
            spamJournal.SpamSaveToFile(spamSaveFileName);
          }
          catch (Exception e)
          {
            Console.WriteLine($"Error {e}");
          }
          break;
        case "5":
          //Option to close the program
          spamContinueAsking = false;
          break;
        default:
          Console.WriteLine("Please select an option from the menu. Just the number.");
          continue;
      }

    } while (spamContinueAsking);

    SpamCloseProgram();

  }

  static void SpamCloseProgram()
  {
    System.Environment.Exit(0);
  }
}