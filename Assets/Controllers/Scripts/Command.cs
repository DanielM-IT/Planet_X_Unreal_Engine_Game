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
        // Runs the user command and will decide on th ethe response according to both the current Unity scene and the key word used.
        Scene currentScene = GameManager._gameManager._storyManager.currentScene;
        string activeScene = GameManager._gameManager.currentActiveScene();

        if (activeScene == "ObjectivesScene")
        {
            switch (response)
            {
                case "next":
                    currentScene = GameManager._gameManager._storyManager.currentScene;
                    if (currentScene != null)
                        GameManager._gameManager._storyManager.currentScene = currentScene.CommanderFirstDialog;
                    break;

                case "yes":
                    currentScene = GameManager._gameManager._storyManager.currentScene;
                    if (currentScene != null)
                        GameManager._gameManager._storyManager.currentScene = currentScene.CommanderSecondDialog;
                    break;

                case "continue":
                    currentScene = GameManager._gameManager._storyManager.currentScene;
                    if (currentScene != null)
                        GameManager._gameManager._storyManager.currentScene = currentScene.CommanderThirdDialog;
                    break;

                case "north":
                    currentScene = GameManager._gameManager._storyManager.currentScene;
                    if (currentScene != null)
                        GameManager._gameManager._storyManager.currentScene = currentScene.CommanderFourthDialog;
                    break;

                case "east":
                    currentScene = GameManager._gameManager._storyManager.currentScene;
                    if (currentScene != null)
                        GameManager._gameManager._storyManager.currentScene = currentScene.CommanderFourthDialog;
                    break;

                case "west":
                    currentScene = GameManager._gameManager._storyManager.currentScene;
                    if (currentScene != null)
                        GameManager._gameManager._storyManager.currentScene = currentScene.CommanderFourthDialog;
                    break;
            }
        }
        else if (activeScene == "ForestScene")
        {
            switch (response)
            {
                case "continue":
                    currentScene = GameManager._gameManager._storyManager.currentScene;
                    if (currentScene != null)
                        GameManager._gameManager._storyManager.currentScene = currentScene.ClueDialog;
                    break;

                case "yes":
                    currentScene = GameManager._gameManager._storyManager.currentScene;
                    if (currentScene != null)
                        GameManager._gameManager._storyManager.currentScene = currentScene.ClueDialogTwo;
                    break;

            }
        }
        else if (activeScene == "CaveEntranceScene")
        {
            switch (response)
            {
                case "yes":
                    currentScene = GameManager._gameManager._storyManager.currentScene;
                    if (currentScene != null)
                        GameManager._gameManager._storyManager.currentScene = currentScene.BagExamination;
                    break;

                case "no":
                    currentScene = GameManager._gameManager._storyManager.currentScene;
                    if (currentScene != null)
                        GameManager._gameManager._storyManager.currentScene = currentScene.CaveEntrance;
                    break;

                case "examine":
                    currentScene = GameManager._gameManager._storyManager.currentScene;
                    if (currentScene != null)
                        GameManager._gameManager._storyManager.currentScene = currentScene.CaveEntrance;
                    break;

                case "sure":
                    currentScene = GameManager._gameManager._storyManager.currentScene;
                    if (currentScene != null)
                        GameManager._gameManager._storyManager.currentScene = currentScene.EnteringCave;
                    break;

            }
        }

        Debug.Log("Execute " + response);
    }
}

