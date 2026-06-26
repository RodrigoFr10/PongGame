using UnityEngine;
using UnityEngine.Networking;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class AuthenticationManager : MonoBehaviour
{
    public TMP_InputField usernameInput;
    public TMP_InputField passwordInput;

    public TextMeshProUGUI messageText;

    string registerURL =
        "http://localhost/pongapi/register.php";

    string loginURL =
        "http://localhost/pongapi/login.php";

    public void Register()
    {
        StartCoroutine(RegisterCoroutine());
    }

    public void Login()
    {
        StartCoroutine(LoginCoroutine());
    }

    IEnumerator RegisterCoroutine()
    {
        WWWForm form = new WWWForm();

        form.AddField("username", usernameInput.text);
        form.AddField("password", passwordInput.text);

        UnityWebRequest www =
            UnityWebRequest.Post(registerURL, form);

        yield return www.SendWebRequest();

        if (www.downloadHandler.text == "Register success")
        {
            //messageText.color = new Color(0f, 1f, 0f);
            messageText.color = Color.green;
        }
        else
        {
            messageText.color = Color.red;
        }
        messageText.text = www.downloadHandler.text;
    }

    IEnumerator LoginCoroutine()
    {
        WWWForm form = new WWWForm();

        form.AddField("username", usernameInput.text);
        form.AddField("password", passwordInput.text);

        UnityWebRequest www =
            UnityWebRequest.Post(loginURL, form);

        yield return www.SendWebRequest();

        string response = www.downloadHandler.text;

        messageText.text = response;

        if (response.StartsWith("Login success|"))
        {
            string[] parts = response.Split('|');

            PlayerData.playerName = parts[1];
            PlayerData.isLoggedIn = true;

            messageText.text = "Login success";
            messageText.color = Color.green;

            Debug.Log("Login set name to: " + PlayerData.playerName);
        }
        else
        {
            messageText.text = response;
            messageText.color = Color.red;
        }
    }
}