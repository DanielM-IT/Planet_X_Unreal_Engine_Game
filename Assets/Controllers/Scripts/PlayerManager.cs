using System.Linq;
using System.Collections.Generic;

public class PlayerManager
{
    private DataService DB = (GameManager.Story != null) ? GameManager.Story.DB : new DataService("GameData.db");
    public bool LoggedIn = false;
    private Player _currentPlayer;
    private int _logInAttempts = 0;

    public bool LogIn(string pUserName, string pPassword)
    {
        List<Player> lcPlayers = DB.Connection.Table<Player>().Where<Player>(
                            x => x.UserName == pUserName && x.Password == pPassword
                       ).ToList();

        bool result = lcPlayers.Count > 0;
        if (!result)
        {
            _logInAttempts++;

            _currentPlayer = null; // CurrentPlayer  
        }
        else
        {
            _logInAttempts = 0;
            _currentPlayer = lcPlayers.First(); // CurrentPlayer

        }

        LoggedIn = result;

        return result;
    }

    public bool RegisterPlayer(string pUserName, string pPassword)
    {
        bool result = false;
        /*
         * Need to check if the player already exists before we register
         * Then Log this player in 
         * if it fails then we don't have a registration
         */
        if (!PlayerExists(pUserName))
        {

            Player newPlayer = new Player
            {
                UserName = pUserName,
                Password = pPassword,
                CurrentScene = GameManager.Story.FirstDialogue.DialogueId
            };

            DB.Connection.Insert(newPlayer);

            result = LogIn(pUserName, pPassword);
        }

        return result;
    }

    public bool PlayerExists(string pUserName)
    {
        return
                (DB.Connection.Table<Player>().Where<Player>(
                          x => x.UserName == pUserName
                     ).ToList().Count > 0);
    }


}
