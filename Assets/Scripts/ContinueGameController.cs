using UnityEngine;

// This is my controller for firing all code assiated with a player continuing their game at the start of their last scene. 
// Almost like a an auto-save feature at the start of each scene.
public class ContinueGameController : MonoBehaviour
{
    public GameObject ContinueButton;

    // This method checks if the player got past the first scene. If they did then it will display the continue button allowing the player to continue at the start of the last scene they left off.
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
