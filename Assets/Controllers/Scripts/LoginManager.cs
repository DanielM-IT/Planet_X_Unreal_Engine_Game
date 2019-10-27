using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginManager : MonoBehaviour
{
    public Text UserName;
    public Text Password;
    public Text PromptText;


    public void loginHandler()
    {
        loginHandler(UserName.text, Password.text);
    }

    public void loginHandler(string pUserName, string pPassword)
    {
        if (string.IsNullOrWhiteSpace(UserName.text) || string.IsNullOrWhiteSpace(Password.text))
        {
            PromptText.text = "Please fill in all fields.";
        }
        else
        {
            if (GameModel.PlayerManager.LogIn(pUserName, pPassword))
            {
                GameManager.gameManager.username = UserName.text;
                SceneManager.LoadScene("GameMenu");
            }
            else if (GameModel.PlayerManager.PlayerExists(pUserName))
            {
                PromptText.text = "Password is incorrect.";
            }
            else
            {
                PromptText.text = "Username or password is incorrect.";
            }
        }
    }

    public void registrationHandler()
    {
        registrationHandler(UserName.text, Password.text, "ObjectivesScene");
    }

    public void registrationHandler(string pUserName, string pPassword, string pCurrentScene)
    {
        if (string.IsNullOrWhiteSpace(UserName.text) || string.IsNullOrWhiteSpace(Password.text))
        {
            PromptText.text = "Please fill in all fields.";
        }
        else
        {
            if (GameModel.PlayerManager.RegisterPlayer(pUserName, pPassword, pCurrentScene))
            {
                GameManager.gameManager.username = UserName.text;
                PromptText.text = "New log in successfully created.";
            }
            else
            {
                PromptText.text = "Sorry but that username already exists.";
            }
        }
    }


}
