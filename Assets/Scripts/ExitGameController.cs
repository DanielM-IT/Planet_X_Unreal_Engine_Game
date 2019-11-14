using UnityEngine;
using UnityEngine.SceneManagement;

// All code needed to allow a player to exit the game will rest here.
// At the moment I have a method which will display the game menu screen if a player clicks the exit game button. I plan to add more functionality later on.
public class ExitGameController : MonoBehaviour
{
    public string sceneName;

    public void ExitGame()
    {
        SceneManager.LoadScene(sceneName);
    }
}
