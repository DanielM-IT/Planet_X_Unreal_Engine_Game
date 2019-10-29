using UnityEngine;

public class Command : MonoBehaviour
{
    //public static Command commands;
    private string response;


    public Command(string paramResponse)
    {
        response = paramResponse;
    }


    public void Execute()
    {
       // Runs the user command and will decide on th ethe response according to both the current Unity scene and the key word used.
        string activeScene = GameManager.gameManager.currentActiveScene();

        if (activeScene == "ObjectivesScene")
        {
            switch (response)
            {
                case "next":
                    GameManager.gameManager.currentDialogueName = "ObjectiveDialogueTwo";
                    GameModel.StoryManager.getDialogue();
                    break;

                case "yes":
                    GameManager.gameManager.currentDialogueName = "ObjectiveDialogueThree";
                    GameModel.StoryManager.getDialogue();
                    break;

                case "continue":
                    GameManager.gameManager.currentDialogueName = "ObjectiveDialogueFour";
                    GameModel.StoryManager.getDialogue();
                    break;

                case "north":
                    GameManager.gameManager.currentDialogueName = "ObjectiveDialogueFive";
                    GameModel.StoryManager.getDialogue();
                    break;

                case "east":
                    GameManager.gameManager.currentDialogueName = "ObjectiveDialogueFive";
                    GameModel.StoryManager.getDialogue();
                    break;

                case "west":
                    GameManager.gameManager.currentDialogueName = "ObjectiveDialogueFive";
                    GameModel.StoryManager.getDialogue();
                    break;
            }
        }
        else if (activeScene == "ForestScene")
        {
            switch (response)
            {
                case "continue":
                    GameManager.gameManager.currentDialogueName = "ForestDialogueTwo";
                    GameModel.StoryManager.getDialogue();
                    break;

                case "definitely":
                    GameManager.gameManager.currentDialogueName = "ForestDialogueThree";
                    GameModel.StoryManager.getDialogue();
                    break;

            }
        }
        else if (activeScene == "CaveEntranceScene")
        {
            switch (response)
            {
                case "yes":
                    GameManager.gameManager.currentDialogueName = "CaveEntranceDialogueTwo";
                    GameModel.StoryManager.getDialogue();
                    break;

                case "no":
                    GameManager.gameManager.currentDialogueName = "CaveEntranceDialogueThree";
                    GameModel.StoryManager.getDialogue();
                    break;

                case "examine":
                    GameManager.gameManager.currentDialogueName = "CaveEntranceDialogueFive";
                    GameModel.StoryManager.getDialogue();
                    break;

                case "sure":
                    GameManager.gameManager.currentDialogueName = "CaveEntranceDialogueFour";
                    GameModel.StoryManager.getDialogue();
                    break;

            }
        }

        Debug.Log("Execute " + response);
    }
}

