using System.Linq;
using System.Collections.Generic;

public class PlayerManager
{
    // Start is called before the first frame update
    private DataService Db = new DataService("PlayerData.db");
    private Player _currentPlayer;
    private int _logInAttempts = 0;
    public bool LoggedIn = false;

    public DataService DB
    {
        get
        {
            return Db;
        }
    }

    public Player CurrentPlayer
    {
        get
        {
            return _currentPlayer;
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

    public bool RegisterPlayer(string pUserName, string pPassword)
    {
        bool result = false;

        if ( ! PlayerExists(pUserName))
        {
            Player newPlayer = new Player
            {
                PlayerName = pUserName,
                PlayerPassword = pPassword,
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
            _currentPlayer = null;
        }
        else
        {
            _logInAttempts = 0;
            _currentPlayer = lcPlayers.First<Player>();
        }

        LoggedIn = result;

        return result;
    }
}
