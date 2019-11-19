using System.Linq;
using System.Collections.Generic;
using UnityEngine;


public class PlayerManager
{
    JSONDropService jsDrop = new JSONDropService { Token = "81692e31-9d31-48b9-9f01-7bfc20983283" };

    // Instantiates a new database file. It will only do this if one doesn't already exist.
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

    // Create the following new database tables.
    public PlayerManager()
    {
        DB.CreateDB(new[]
        {
            typeof(Player),
        });
    }

    // Checks if a player exists in the database. If 1 is returned they do, if 0 then they do not.
    public bool PlayerExists(string pUserName)
    {
        jsDrop.Select<Player, JsnReceiver>("PlayerName = '" + pUserName + "'", jsnListReceiverDel, jsnReceiverDel);
  


        return (Db.Connection.Table<Player>().Where<Player>(
            x => x.PlayerName == pUserName
            ).ToList<Player>().Count > 0);
    }

    // This first uses the player exists method to check for this. If they do not then a new player record is created in the player table.
    public void RegisterPlayer(string pUserName, string pPassword, string pCurrentScene, int pPlayerXP)
    {
        //bool result = false;

        //if (!PlayerExists(pUserName))
        //{
            jsDrop.Store<Player, JsnReceiver>(new List<Player>
            {
                new Player{PlayerName = pUserName, PlayerPassword = pPassword, CurrentStorySection = pCurrentScene, PlayerXP = pPlayerXP}
            }, jsnRegisterReceiverDel);


        jsDrop.Select<Player, JsnReceiver>("PlayerName = '" + pUserName + "'", jsnListReceiverDel, jsnReceiverDel);
        //    result = true;
        //}


        //return result;
    }

    public void jsnPlayerExistsReceiverDel(List<Player> pReceivedList)
    {
        Debug.Log("Received items " + pReceivedList.Count());
        foreach (Player lcReceived in pReceivedList)
        {
            Debug.Log("Received {" + lcReceived.PlayerName + "," + lcReceived.PlayerPassword + "," + lcReceived.PlayerXP.ToString() + "}");
        }// for

        // To do: produce an appropriate response
    }

    public void jsnRegisterReceiverDel(JsnReceiver pReceived)
    {
        Debug.Log(pReceived.JsnMsg + " ..." + pReceived.Msg);
        // To do: parse and produce an appropriate response
    }


    // The login method. This checks if the username and password passed through the paramaters are both in the database in the database and 
    // if they are the result is returned as true and the login attampt count is reverted back to 0. If not then false is returned and +1 is added to their login attempt count. This count I am hoping to use in a future functionality of 
    // locking a player out if they enter incorrect details too many times.
    public void LogIn(string pUserName, string pPassword)
    {
        jsDrop.Select<Player, JsnReceiver>($"PlayerName = '{pUserName}' AND Password = '{pPassword}'"/*"PlayerName = '" + pUserName + "' AND Password = '" + pPassword + "'"*/, jsnListReceiverDel, jsnReceiverDel);


        //List<Player> lcPlayers = Db.Connection.Table<Player>().Where<Player>(
        //    x => x.PlayerName == pUserName && x.PlayerPassword == pPassword
        //    ).ToList<Player>();

        //bool result = lcPlayers.Count > 0;
        //if (!result)
        //{
        //    _logInAttempts++;
        //}
        //else
        //{
        //    _logInAttempts = 0;
        //    GameManager.gameManager.username = pUserName;
        //}

        //LoggedIn = result;

        //return result;
    }

    // This method retrieves the players current scene from their last playing session.
    public void continueLastScene()
    {
        Player currentSection = Db.Connection.Table<Player>().Where(
                   x => x.PlayerName == GameManager.gameManager.username
                   ).ToList<Player>().FirstOrDefault<Player>();

        GameManager.gameManager.currentScene = currentSection.CurrentStorySection;
    }

    // This method updates the current players current story scene.
    public void updatePlayerCurrentScene()
    {
        Db.Connection.Execute("UPDATE Player SET CurrentStorySection = ? Where PlayerName = ?", GameManager.gameManager.currentScene, GameManager.gameManager.username);
    }

    // This method retrieves the current players current xp points.
    public void getCurrentXpPoints()
    {
        Player currentXpPoints = Db.Connection.Table<Player>().Where(
           x => x.PlayerName == GameManager.gameManager.username
           ).ToList<Player>().FirstOrDefault<Player>();

        GameManager.gameManager.currentXpPoints = currentXpPoints.PlayerXP;
    }

    // This method updates the current players xp points.
    public void updatePlayerXpPoints()
    {
        Db.Connection.Execute("UPDATE Player SET PlayerXP = ? Where PlayerName = ?", GameManager.gameManager.currentXpPoints, GameManager.gameManager.username);
    }

    public void jsnReceiverDel(JsnReceiver pReceived)
    {
        Debug.Log(pReceived.JsnMsg + " ..." + pReceived.Msg);
        // To do: parse and produce an appropriate response
    }

    public void jsnListReceiverDel(List<Player> pReceivedList)
    {
        Debug.Log("Received items " + pReceivedList.Count());
        foreach (Player lcReceived in pReceivedList)
        {
            Debug.Log("Received {" + lcReceived.PlayerName + "," + lcReceived.PlayerPassword + "," + lcReceived.PlayerXP.ToString() + "}");
        }// for

        // To do: produce an appropriate response
    }

}
