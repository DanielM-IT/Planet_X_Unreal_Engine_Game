using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;


public class SceneController : MonoBehaviour
{
    // This public variable allows me to change the scene in the Unity editor.
    public string sceneName;


    private void OnTriggerEnter(Collider newScene)
    {
        updatePlayerCurrentStorySection();
        SceneManager.LoadScene(sceneName);
    }

    // Used to load a new scene. The intention for this methos is to be attached to a button.
    public void buttonChangeOfScene()
    {
        GameModel.PlayerManager.updatePlayerXpPoints();
        SceneManager.LoadScene(sceneName);
    }

    public void buttonContinueLastScene()
    {
        GameModel.PlayerManager.continueLastScene();
        SceneManager.LoadScene(GameManager.gameManager.currentScene);
    }

    public void updatePlayerCurrentStorySection()
    {
        if (GameManager.gameManager.currentActiveScene() == "ObjectivesScene")
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
