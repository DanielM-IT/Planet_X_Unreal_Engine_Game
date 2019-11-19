using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TestJsnDropNetworkService : MonoBehaviour
{
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
            Debug.Log("Received {" + lcReceived.PlayerName + "," + lcReceived.PlayerPassword + "," + lcReceived.PlayerXP.ToString()+"}");
        }// for

        // To do: produce an appropriate response
    }
    // Start is called before the first frame update
    void Start()
    {
        #region Test jsn drop
        JSONDropService jsDrop = new JSONDropService { Token = "81692e31-9d31-48b9-9f01-7bfc20983283" };
        
        // Create table player
        jsDrop.Create<Player, JsnReceiver>(new Player
        {
            PlayerName = "UUUUUUUUUUUUUUUUUUUUUUUUUUU",
            PlayerXP = 0,
            PlayerPassword = "***************************"
        }, jsnReceiverDel);

        // Store player records
        jsDrop.Store<Player, JsnReceiver> (new List<Player>
        {
            new Player{PlayerName = "Jack",PlayerXP = 100,PlayerPassword ="test"},
            new Player{PlayerName = "Jonny",PlayerXP = 200,PlayerPassword ="test1"},
            new Player{PlayerName = "Jill",PlayerXP = 300,PlayerPassword ="test2"}
         }, jsnReceiverDel);
        
        // Retreive all player records
        jsDrop.All<Player, JsnReceiver>(jsnListReceiverDel, jsnReceiverDel);
        
        jsDrop.Select<Player, JsnReceiver>("PlayerXP > 200", jsnListReceiverDel, jsnReceiverDel);
        
        jsDrop.Delete<Player, JsnReceiver>("PlayerName = 'Calida'", jsnReceiverDel);
        
        //jsDrop.Drop<Person, JsnReceiver>(jsnReceiverDel);
        #endregion

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
