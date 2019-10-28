using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitGameController : MonoBehaviour
{
    public string sceneName;

    public void ExitGame()
    {
        SceneManager.LoadScene(sceneName);
    }
}
