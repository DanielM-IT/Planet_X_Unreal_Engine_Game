using UnityEngine;
using UnityEngine.UI;

public class Command : MonoBehaviour
{
    //public static Command commands;
    private string response;
    public Button enterForestButton;

    private void Start()
    {
        // Future implementation
        //enterForestButton.gameObject.SetActive(false);
    }

    public Command(string paramResponse)
    {
        response = paramResponse;
    }


    public void Execute()
    {

        Scene currentScene = GameManager.gameManager.gameModel.currentScene;
        string activeScene = GameManager.gameManager.currentActiveScene();
        if (activeScene == "ObjectivesScene")
        {
            switch (response)
            {
                case "next":
                    currentScene = GameManager.gameManager.gameModel.currentScene;
                    if (currentScene != null)
                        GameManager.gameManager.gameModel.currentScene = currentScene.CommanderFirstDialog;
                    break;

                case "yes":
                    currentScene = GameManager.gameManager.gameModel.currentScene;
                    if (currentScene != null)
                        GameManager.gameManager.gameModel.currentScene = currentScene.CommanderSecondDialog;
                    break;

                case "continue":
                    currentScene = GameManager.gameManager.gameModel.currentScene;
                    if (currentScene != null)
                        GameManager.gameManager.gameModel.currentScene = currentScene.CommanderThirdDialog;
                    break;

                case "north":
                    currentScene = GameManager.gameManager.gameModel.currentScene;
                    if (currentScene != null)
                        GameManager.gameManager.gameModel.currentScene = currentScene.CommanderFourthDialog;
                    break;

                case "east":
                    currentScene = GameManager.gameManager.gameModel.currentScene;
                    if (currentScene != null)
                        GameManager.gameManager.gameModel.currentScene = currentScene.CommanderFourthDialog;
                    break;

                case "west":
                    currentScene = GameManager.gameManager.gameModel.currentScene;
                    if (currentScene != null)
                        GameManager.gameManager.gameModel.currentScene = currentScene.CommanderFourthDialog;
                    break;
            }
        }
        else if (activeScene == "ForestScene")
        {
            switch (response)
            {
                case "continue":
                    currentScene = GameManager.gameManager.gameModel.currentScene;
                    if (currentScene != null)
                        GameManager.gameManager.gameModel.currentScene = currentScene.ClueDialog;
                    break;

                case "yes":
                    currentScene = GameManager.gameManager.gameModel.currentScene;
                    if (currentScene != null)
                        GameManager.gameManager.gameModel.currentScene = currentScene.ClueDialogTwo;
                    break;

            }
        }
        else if (activeScene == "CaveEntranceScene")
        {
            switch (response)
            {
                case "yes":
                    currentScene = GameManager.gameManager.gameModel.currentScene;
                    if (currentScene != null)
                        GameManager.gameManager.gameModel.currentScene = currentScene.BagExamination;
                    break;

                case "no":
                    currentScene = GameManager.gameManager.gameModel.currentScene;
                    if (currentScene != null)
                        GameManager.gameManager.gameModel.currentScene = currentScene.CaveEntrance;
                    break;

                case "examine":
                    currentScene = GameManager.gameManager.gameModel.currentScene;
                    if (currentScene != null)
                        GameManager.gameManager.gameModel.currentScene = currentScene.CaveEntrance;
                    break;

                case "sure":
                    currentScene = GameManager.gameManager.gameModel.currentScene;
                    if (currentScene != null)
                        GameManager.gameManager.gameModel.currentScene = currentScene.EnteringCave;
                    break;

            }
        }

        Debug.Log("Execute " + response);
    }
}

