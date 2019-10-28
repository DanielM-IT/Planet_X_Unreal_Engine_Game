// This parses all input entered by the user. It checks first that something was entered then runs it through my command map.
public class CommandProcessor
{
    public string ParseInput(string paramInputCommand)
    {
        string strResult = "Unrecognized input";

        paramInputCommand = paramInputCommand.ToLower();
        if (!string.IsNullOrWhiteSpace(paramInputCommand))
        {
            CommandMap commandMap = new CommandMap();
            if (commandMap.executeCommand(paramInputCommand))
            {
                return commandMap.result;
            }
            else
            {
            return strResult;
            }
        }

        return null; ;
    }
}
