using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneController : MonoBehaviour
{
    // This public variable allows me to change the scene in the Unity editor.
    public string sceneName;


    private void OnTriggerEnter(Collider newScene)
    {
        updatePlayerCurrentStorySection();
        SceneManager.LoadScene(sceneName);
    }

    // Used to load a new scene. The intention for this method is to be attached to a button.
    public void buttonChangeOfScene()
    {
        updatePlayerCurrentStorySection();
        GameModel.PlayerManager.updatePlayerXpPoints();
        SceneManager.LoadScene(sceneName);
    }

    // Used to continue the last active scene. The intention for this method is to be attached to a continue button.
    public void buttonContinueLastScene()
    {
        GameModel.PlayerManager.continueLastScene();
        SceneManager.LoadScene(GameManager.gameManager.currentScene);
    }

    // Upon switching to a new scene this method is used by the database methods to update a players current scene.
    public void updatePlayerCurrentStorySection()
    {
        if (GameManager.gameManager.currentActiveScene() == "GameMenu")
        {
            GameManager.gameManager.currentScene = "ObjectivesScene";
            GameModel.PlayerManager.updatePlayerCurrentScene();
        }
        else if (GameManager.gameManager.currentActiveScene() == "ObjectivesScene")
        {
            GameModel.PlayerManager.updatePlayerXpPoints();
            GameManager.gameManager.currentScene = "ForestScene";
            GameModel.PlayerManager.updatePlayerCurrentScene();
        }
        else if (GameManager.gameManager.currentActiveScene() == "ForestScene")
        {
            GameModel.PlayerManager.updatePlayerXpPoints();
            GameManager.gameManager.currentScene = "CaveEntranceScene";
            GameModel.PlayerManager.updatePlayerCurrentScene();
        }
        else
        {
            GameModel.PlayerManager.updatePlayerXpPoints();
            GameManager.gameManager.currentScene = "ForestScene";
        }
    }
}
