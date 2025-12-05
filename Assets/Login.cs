using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class Login : MonoBehaviour
{
    [SerializeField] private string setUsername = "jared";
    [SerializeField] private string setPassword = "12345";

    [SerializeField] public TMP_InputField userInput;
    [SerializeField] public TMP_InputField passwordInput;

    [SerializeField] public TMP_Text message;

    [SerializeField] private string nextScene = "MyScene";
    public void LoginButton()
    {
        string user = userInput.text;
        string pass = passwordInput.text;

        if(user == setUsername && pass == setPassword)
        {
            Debug.Log("Login Successful");
            message.text = "Login Successful";
            SceneManager.LoadScene(nextScene);
        }
        else
        {
            Debug.Log("Login Failed");
            message.text = "Login Failed";
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
