using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    // There can be only one instance of this since it is static. It allows this script to be accessed by all other scripts.
    public static GameManager _gameManager;

    // This creates a new instance of the gameModel script
    public static StoryManager _storyManager;
    public static PlayerManager _playerManager;

    public Text userName;
    public Text password;
    public Text promptMessage;


    public static StoryManager Story
    {
        get { return _storyManager; }
    }

    public static PlayerManager PlayerManager
    {
        get { return _playerManager; }
    }

    /* This method is a one off use for the entire time the instance of this script exists.
    It is used to initialize game states and variables while the game is initializing.
    */
    private void Awake()
     {
        if (_gameManager == null)
        {
            _gameManager = this;
            _storyManager = new StoryManager();
            _playerManager = new PlayerManager();

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

    public void CheckUserDetails()
    {
        CheckDetails(userName.text, password.text);
    }

    public void CheckDetails(string pUserName, string pPassword)
    {
        if (PlayerManager.LogIn(pUserName, pPassword))
        {
            // show scene
        }
        else
        {
            if (PlayerManager.PlayerExists(pUserName))
            {
                promptMessage.text = "Please enter a valid password";
            }
            else
            {
                PlayerManager.RegisterPlayer(pUserName, pPassword);
                if (PlayerManager.LoggedIn)
                {
                    // show scene
                }
            }
        }
    }


}
