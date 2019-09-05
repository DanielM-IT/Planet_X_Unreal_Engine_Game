using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject inputField;
    public GameObject outputField;
    public GameObject hintText;

    private int counter;


    private void Start()
    {
        inputField.gameObject.SetActive(false);
        outputField.gameObject.SetActive(false);
    }

    public void showHideByButton()
    {
        counter++;
        if (counter % 2 == 1)
        {
            inputField.gameObject.SetActive(false);
            outputField.gameObject.SetActive(false);
        }
        else
        {
            inputField.gameObject.SetActive(true);
            outputField.gameObject.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        inputField.gameObject.SetActive(true);
        outputField.gameObject.SetActive(true);
        hintText.gameObject.SetActive(false);
    }


}
