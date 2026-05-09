using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class OnlineLeaderboard : MonoBehaviour
{
    public static OnlineLeaderboard instance;

    string submitURL = "http://localhost/pongapi/submit_score.php";

    void Awake()
    {
        if (instance == null)
        {
            instance = this;

            DontDestroyOnLoad(gameObject); //nao destruir ao carregar nova cena
        }
        else
        {
            Destroy(gameObject); //destruir copias do leaderboard
        }
    }

    public void SubmitScore(string playerName, int score)
    {
        StartCoroutine(SendScore(playerName, score));
    }

    IEnumerator SendScore(string playerName, int score)
    {
        WWWForm form = new WWWForm();

        form.AddField("player_name", playerName);
        form.AddField("score", score);

        UnityWebRequest www =
            UnityWebRequest.Post(submitURL, form);

        yield return www.SendWebRequest();

        if (www.result == UnityWebRequest.Result.Success)
        {
            Debug.Log("Score submitted successfully");
            Debug.Log(www.downloadHandler.text);
        }
        else
        {
            Debug.Log("Error submitting score");
            Debug.Log(www.error);
        }
    }
}