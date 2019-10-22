using UnityEngine;
using UnityEngine.UI;

public class TextInput : MonoBehaviour
{
    // Creates instances of the following objects.
    InputField input;
    InputField.SubmitEvent submitEvent;
    public Text output;

    void Start()
    {
        // Gets the InputField component.
        input = GetComponent<InputField>();

        // If get a null then this script is running when it should not be.
        if (input != null)
        {
            // Creates a new event for submitting text and adds a listener which listens out for user input.
            submitEvent = new InputField.SubmitEvent();
            submitEvent.AddListener(SubmitInput);
            input.onEndEdit = submitEvent;

            // Displays the first dialog from the game model on first scene load.
            if (GameManager._gameManager.currentActiveScene() == "ObjectivesScene")
            {
                output.text = GameManager._gameManager._storyManager.currentScene.story;
            }
            else if (GameManager._gameManager.currentActiveScene() == "ForestScene")
            {
                output.text = GameManager._gameManager._storyManager.currentScene.story;
            }
            else if (GameManager._gameManager.currentActiveScene() == "CaveEntranceScene")
            {
                output.text = GameManager._gameManager._storyManager.currentScene.story;
            }
        }
    }

    // Takes the received input and sends it the CommandProcessor class as a parameter. Then takes the received 
    // result and puts it into the text object.
    private void SubmitInput(string submittedInput)
    {
        string currentText = output.text;

        CommandProcessor command = new CommandProcessor();
        output.text = output.text + "\n" + "\n" + (command.ParseInput(submittedInput));

        // Clears all text from the input field
        input.text = null;
    }

    // Adds the entered text to the debug log for debugging purposes.
    private void ChangeInput(string submittedInput)
    {
        Debug.Log("text was " + submittedInput);
    }

}
