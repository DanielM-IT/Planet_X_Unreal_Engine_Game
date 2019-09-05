using UnityEngine;
using System.Collections.Generic;

public class CommandMap 
{
    private Dictionary<string, Command> dictionaryOfCommands;

    public string result = string.Empty;

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
    }


    public bool executeCommand(string paramInputCommandString)
    {
        Command command;

        if (dictionaryOfCommands.ContainsKey(paramInputCommandString))
        {
            command = dictionaryOfCommands[paramInputCommandString];
            command.Execute();
            result = GameManager.gameManager.gameModel.currentScene.story;
            return true;
        }
        return false;
    }
}
