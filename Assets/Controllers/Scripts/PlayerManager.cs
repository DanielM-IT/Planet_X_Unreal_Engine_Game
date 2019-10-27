using System.Linq;
using System.Collections.Generic;

public class PlayerManager
{
    // Start is called before the first frame update
    private DataService Db = new DataService("PlayerData.db");
    private int _logInAttempts = 0;
    public bool LoggedIn = false;

    public DataService DB
    {
        get
        {
            return Db;
        }
    }

    public int LoginAttempts
    {
        get
        {
            return _logInAttempts;
        }
    }

    public PlayerManager()
    {
        DB.CreateDB(new[]
        {
            typeof(Player),
        });
    }

    public bool PlayerExists(string pUserName)
    {
        return (Db.Connection.Table<Player>().Where<Player>(
            x => x.PlayerName == pUserName
            ).ToList<Player>().Count > 0);
    }

    public bool RegisterPlayer(string pUserName, string pPassword, string pCurrentScene)
    {
        bool result = false;

        if ( ! PlayerExists(pUserName))
        {
            Player newPlayer = new Player
            {
                PlayerName = pUserName,
                PlayerPassword = pPassword,
                CurrentStorySection = pCurrentScene
            };

            Db.Connection.Insert(newPlayer);

            result = true;
        }


        return result;
    }

    public bool LogIn(string pUserName, string pPassword)
    {
        List<Player> lcPlayers = Db.Connection.Table<Player>().Where<Player>(
            x => x.PlayerName == pUserName && x.PlayerPassword == pPassword
            ).ToList<Player>();

        bool result = lcPlayers.Count > 0;
        if (!result)
        {
            _logInAttempts++;
        }
        else
        {
            _logInAttempts = 0;
            GameManager.gameManager.username = pUserName;
        }

        LoggedIn = result;

        return result;
    }

    public void continueLastScene()
    {
        Player currentSection = Db.Connection.Table<Player>().Where(
                   x => x.PlayerName == GameManager.gameManager.username
                   ).ToList<Player>().FirstOrDefault<Player>();

        GameManager.gameManager.currentScene = currentSection.CurrentStorySection;
    }

    public void updatePlayerCurrentScene()
    {
        Db.Connection.Execute("UPDATE Player SET CurrentStorySection = ? Where PlayerName = ?", GameManager.gameManager.currentScene, GameManager.gameManager.username);
    }

    public void updatePlayerXpPoints()
    {
        Db.Connection.Execute("UPDATE Player SET PlayerXP = ? Where PlayerName = ?", GameManager.gameManager.currentXpPoints, GameManager.gameManager.username);
    }
}
