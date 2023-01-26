/*
Author: Team SPAM Jeremiah Powell, Angelo Arellano Gaona, Jeffrey Meldrum, 
Description:
Responsibilities: Genterate an 
interactable menu for use. 
Attributes: number based menu 
with action lables. 
Behaviors: An interactable menu 
will allow the user to perform 
different actions in the journal. 
*/

public class SpamMenu
{
  /*TODO implement attributes to store the menu options*/
  public List<String> _spamOptions = new List<String>();


  public SpamMenu()
  {
    _spamOptions.Add("1.Write");
    _spamOptions.Add("2.Display");
    _spamOptions.Add("3.Load");
    _spamOptions.Add("4.Save");
    _spamOptions.Add("5.Exit\n");
  }

  public void SpamDisplayMenu()
  {
    for (int i = 0; i < _spamOptions.Count; i++)
    {
      Console.WriteLine(_spamOptions[i]);
    }
    /*To do implement method to display menu to the user*/
  }

  public String SpamAskForMenuSelection()
  {
    String userResponse = Console.ReadLine();
    return userResponse;

    /*To do implement method to ask for menu selection from the terminal and return it*/
  }
}