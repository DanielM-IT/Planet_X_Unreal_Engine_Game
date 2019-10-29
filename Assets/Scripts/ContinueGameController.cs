using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueGameController : MonoBehaviour
{
    public GameObject ContinueButton;

    private void Awake()
    {
        GameModel.PlayerManager.continueLastScene();
        if (GameManager.gameManager.currentScene == "GameMenu" || GameManager.gameManager.currentScene == "ObjectivesScene")
        {
            ContinueButton.gameObject.SetActive(false);
        }
        else
        {
            ContinueButton.gameObject.SetActive(true);
        }
    }
}
