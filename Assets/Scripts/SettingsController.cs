using UnityEngine;

// This class is used to control my settings window. At the moment it only serves to allow a player to exit their current game. 
// Later on this class will allow me to add additional settings into the game. For instance the ability to control sound levels.
public class SettingsController : MonoBehaviour
{
    public GameObject Settings;
    private int counter;


    private void Start()
    {
        Settings.gameObject.SetActive(false);
    }

    public void showHideByButton()
    {
        counter++;

        if (counter % 2 == 0)
        {
            Settings.gameObject.SetActive(false);
        }
        else
        {
            Settings.gameObject.SetActive(true);
        }
    }
}
