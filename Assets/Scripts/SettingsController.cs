using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
