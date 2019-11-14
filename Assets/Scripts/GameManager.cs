using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    // There can be only one instance of this since it is static. It allows this script to be accessed by all other scripts.
    public static GameManager gameManager;

    // This creates a new instance of the gameModel script
    public static GameModel gameModel;

    public int currentXpPoints;
    public string username;
    public string currentScene;
    public string currentDialogue;
    public string currentDialogueName;
    
    // This method is a one off use for the entire time the instance of this script exists.
    // It is used to initialize game states and variables while the game is initializing.
    private void Awake()
    {
        if (gameManager == null)
        {
            gameManager = this;
            gameModel = new GameModel();

        }
        // If a scene exists when it shouldn't it will be destroyed.
        else
        {
            Destroy(gameObject);
        }
    }


    // Retrieves the name of the current scene that is active.
    public string currentActiveScene()
    {
        return SceneManager.GetActiveScene().name;
    }
}
