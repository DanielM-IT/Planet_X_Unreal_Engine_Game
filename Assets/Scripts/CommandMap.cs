using System.Collections.Generic;

public class CommandMap 
{
    private Dictionary<string, Command> dictionaryOfCommands;

    // Variable with an empty string. Used in a further down method to clear the story variable.
    public string result = string.Empty;

    // Dictionary of recognized words. 
    public CommandMap()
    {
        dictionaryOfCommands = new Dictionary<string, Command>();
        dictionaryOfCommands.Add("next", new Command("next"));
        dictionaryOfCommands.Add("yes", new Command("yes"));
        dictionaryOfCommands.Add("no", new Command("no"));
        dictionaryOfCommands.Add("sure", new Command("sure"));
        dictionaryOfCommands.Add("examine", new Command("examine"));
        dictionaryOfCommands.Add("continue", new Command("continue"));
        dictionaryOfCommands.Add("north", new Command("north"));
        dictionaryOfCommands.Add("east", new Command("east"));
        dictionaryOfCommands.Add("west", new Command("west"));
        dictionaryOfCommands.Add("definitely", new Command("definitely"));
    }

    // Checks to see if the user input is in the dictionary of recognised key words. If it is it will run the command through the command class.
    public bool executeCommand(string paramInputCommandString)
    {
        Command command;

        if (dictionaryOfCommands.ContainsKey(paramInputCommandString))
        {
            command = dictionaryOfCommands[paramInputCommandString];
            command.Execute();
            result = GameManager.gameManager.currentDialogue;
            return true;
        }
        return false;
    }
}
