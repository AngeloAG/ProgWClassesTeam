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
    Console.WriteLine("Hello Develop02 World!");
    SpamCloseProgram();
    
  }

  static void SpamCloseProgram()
  {
    System.Environment.Exit(0);
  }
}