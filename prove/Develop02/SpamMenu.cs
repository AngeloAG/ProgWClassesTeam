/*
Author: Team SPAM
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
  public List<String> _options = new List<String>();


  public SpamMenu()
  {
    _options.Add("1.Write");
    _options.Add("2.Display");
    _options.Add("3.Load");
    _options.Add("4.Save");
    _options.Add("5.Exit\n");

  }

  public void SpamDisplayMenu()
  {
    for (int i = 0; i < _options.Count; i++)
    {
      Console.WriteLine(_options[i]);
    }
    /*To do implement method to display menu to the user*/
  }

  public String SpamAskForMenuSelection()
  {
    String user_response = Console.ReadLine();
    return user_response;

    /*To do implement method to ask for menu selection from the terminal and return it*/
  }
}