using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class NetworkService : MonoBehaviour
{
    JSONDropService jsDrop = new JSONDropService { Token = "81692e31-9d31-48b9-9f01-7bfc20983283" };

    void Start()
    {
        #region Test jsn drop

        // Create table player
        jsDrop.Create<Player, JsnReceiver>(new Player
        {
            PlayerName = "UUUUUUUUUUUUUUUUUUUUUUUUUUU",
            PlayerPassword = "***************************",
            CurrentStorySection = "UUUUUUUUUUUUUUUUUUUUUUUUUUUU",
            PlayerXP = 0
        }, jsnReceiverDel);

        // Store player records
        jsDrop.Store<Player, JsnReceiver>(new List<Player>
        {
            new Player{PlayerName = "Jack", PlayerPassword ="test", CurrentStorySection ="GameMenu", PlayerXP = 100,},
            new Player{PlayerName = "Jonny", PlayerPassword ="test1", CurrentStorySection ="GameMenu", PlayerXP = 200},
            new Player{PlayerName = "Jill", PlayerPassword ="test2", CurrentStorySection ="GameMenu", PlayerXP = 300}
         }, jsnReceiverDel);

        jsDrop.All<Player, JsnReceiver>(jsnListReceiverDel, jsnReceiverDel);
        jsDrop.Select<Player, JsnReceiver>("PlayerXP > 200", jsnListReceiverDel, jsnReceiverDel);

        #endregion
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
