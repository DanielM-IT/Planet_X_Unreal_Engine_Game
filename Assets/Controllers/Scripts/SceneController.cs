using UnityEngine;
using UnityEngine.SceneManagement;

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

    public void buttonChangeOfScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
