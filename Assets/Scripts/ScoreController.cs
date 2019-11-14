using UnityEngine;
using UnityEngine.UI;
using System;

// This is used to control the gaining of xp points by the player. At the moment I have this form of scoring working when I interact with quest items in the scene. Later I would
// like to finish implementing my inventory and have xp also gained by collecting items for it.
public class ScoreController : MonoBehaviour
{
    public Text currentXpPoints;

    // This method gets the current players current xp points.
    private void Start()
    {
        GameModel.PlayerManager.getCurrentXpPoints();
        currentXpPoints.text = Convert.ToString(GameManager.gameManager.currentXpPoints);
    }

    // This method gets the current xp points and displays them in the UI.
    private void Update()
    {
        currentXpPoints.text = Convert.ToString(GameManager.gameManager.currentXpPoints);
    }

    // Methos is used in updating of xp points.
    public void updateXpPointsOnGameLeave()
    {
        GameModel.PlayerManager.updatePlayerXpPoints();
    }
}
