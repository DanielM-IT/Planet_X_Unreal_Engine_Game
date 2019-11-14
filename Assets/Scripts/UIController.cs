using UnityEngine;

public class UIController : MonoBehaviour
{
    // Creates a public instance of these objects visible on Unity. The desired object is then dropped into each slot.
    public GameObject inputField;
    public GameObject outputField;
    public GameObject hintText;

    // Variable to store click counts
    private int counter;

    // Sets the fields to be disabled initially
    private void Start()
    {
        inputField.gameObject.SetActive(false);
        outputField.gameObject.SetActive(false);
    }

    // Checks the click number and sets or disables the objects accordingly.
    public void showHideByButton()
    {
        counter++;

        if (counter % 2 == 1)
        {
            if (inputField.activeSelf == true && outputField.activeSelf == true)
            {
                inputField.gameObject.SetActive(false);
                    outputField.gameObject.SetActive(false);
            }
            else if (inputField.activeSelf == false && outputField.activeSelf == false)
            {
                inputField.gameObject.SetActive(true);
                outputField.gameObject.SetActive(true);
            }
        }
        else
        {
            if (inputField.activeSelf == false && outputField.activeSelf == false)
            {
                inputField.gameObject.SetActive(true);
                outputField.gameObject.SetActive(true);
            }
            else if (inputField.activeSelf == true && outputField.activeSelf == true)
            {
                inputField.gameObject.SetActive(false);
                outputField.gameObject.SetActive(false);
            }
        }
    }

    // Enables and disable objects when the collider of an object this script is attached to is triggered.
    private void OnTriggerEnter(Collider storyObjects)
    {
        inputField.gameObject.SetActive(true);
        outputField.gameObject.SetActive(true);
        hintText.gameObject.SetActive(false);

        GetComponent<Collider>().enabled = false;

        GameManager.gameManager.currentXpPoints = GameManager.gameManager.currentXpPoints + 150;
    }
}
