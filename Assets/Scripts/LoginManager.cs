using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// 
public class LoginManager : MonoBehaviour
{
    public Text UserName;
    public Text Password;
    public Text PromptText;

    // This method gets the text that is currently in the username and password text fields and passes them as two paramaters.
    public void loginHandler()
    {
        loginHandler(UserName.text, Password.text);
    }

    // This method first checks that the text fields weren't empty if they aren't then it go to the Login method to check the login. If it comes back as
    // correct it will place the users username in a public variable for identification purposes . If it coomes back as incorrect it will display an error message.
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
            else
            {
                PromptText.text = "Username or password is incorrect.";
            }
        }
    }

    // This first method passes three paramaters for registration. The username and password entered in the two text boxes and the first scene name which will be used to set 
    // the new players current scene to the first scene.
    public void registrationHandler()
    {
        registrationHandler(UserName.text, Password.text, "GameMenu");
    }

    // Takes the three paramaters after first checking that the two text fields had text in them and passes the paramaters to the registerplayer method. 
    // If it comes back as successful it will display a success message, if unsuccessful a username already exists message.
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
                PromptText.text = "New log in successfully created.";
            }
            else
            {
                PromptText.text = "Sorry but that username already exists.";
            }
        }
    }


}
