using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;


public class SceneController : MonoBehaviour
{
    // This public variable allows me to change the scene in the Unity editor.
    public string sceneName;


    private void OnTriggerEnter(Collider other)
    {
        // Can load scenes by name
        SceneManager.LoadScene(sceneName);
        
        // If I wanted to restart the scene instead
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Used to load a new scene. The intention for this methos is to be attached to a button.
    public void buttonChangeOfScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void buttonContinueLastScene()
    {
        GameModel.PlayerManager.continueLastScene();
        SceneManager.LoadScene(GameManager.gameManager.currentScene);
    }

    public void updatePlayerCurrentStorySection()
    {
        if (GameManager.gameManager.currentActiveScene() == "Login")
        {
            GameManager.gameManager.currentScene = "ObjectivesScene";

        }
        else if (GameManager.gameManager.currentActiveScene() == "ObjectivesScene")
        {
            GameManager.gameManager.currentScene = "ForestScene";

        }
        else if (GameManager.gameManager.currentActiveScene() == "ForestScene")
        {
            GameManager.gameManager.currentScene = "CaveEntranceScene";

        }

    }
}
