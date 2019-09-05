using UnityEngine;

public class ForestSceneManager : MonoBehaviour
{
    // There can be only one instance of this since it is static. It allows this script to be accessed by all other scripts.
    public static ForestSceneManager forestSceneManager;

    // This creates a new instance of the gameModel script
    public GameModel gameModel;

    /* This method is a one off use for the entire time the instance of this script exists.
    It is used to initialize scene states and variables while the scene is initializing.
    */
    private void Awake()
    {
        if (forestSceneManager == null)
        {
            forestSceneManager = this;
            gameModel = new GameModel();

        }
        // If a scene exists when it shouldn't it will be destroyed.
        else
        {
            Destroy(gameObject);
        }
    }
}
