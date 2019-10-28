using UnityEngine;
using UnityEngine.UI;
using System;


public class ScoreController : MonoBehaviour
{
    public Text currentXpPoints;

    private void Start()
    {
        GameModel.PlayerManager.getCurrentXpPoints();
        currentXpPoints.text = Convert.ToString(GameManager.gameManager.currentXpPoints);
    }

    private void Update()
    {
        currentXpPoints.text = Convert.ToString(GameManager.gameManager.currentXpPoints);
    }

    public void updateXpPointsOnGameLeave()
    {
        GameModel.PlayerManager.updatePlayerXpPoints();
    }
}
