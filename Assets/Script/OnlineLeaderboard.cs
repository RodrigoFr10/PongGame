using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using TMPro; //text mesh pro
using UnityEngine.SceneManagement;

public class OnlineLeaderboard : MonoBehaviour
{
    public static OnlineLeaderboard instance;

    string submitURL = "http://localhost/pongapi/submit_score.php";
    string leaderboardURL = "http://localhost/pongapi/get_leaderboard.php";
    public TextMeshProUGUI leaderboardText;

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
    void Start()
    {
        DownloadLeaderboard();
    }

    void OnEnable()//quando essa cena for habilitada, rodar a funcao
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode) //quando a cena for menu, atualiza o leaderboard
    {
        if (scene.name == "MainMenuScene")
        {
            leaderboardText =
                GameObject.Find("OnlineLeaderboardText")
                .GetComponent<TMPro.TextMeshProUGUI>();

            DownloadLeaderboard();
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
    public void DownloadLeaderboard()
    {
        StartCoroutine(GetLeaderboard());
    }

    IEnumerator GetLeaderboard()
    {
        UnityWebRequest www =
            UnityWebRequest.Get(leaderboardURL);

        yield return www.SendWebRequest();

        if (www.result == UnityWebRequest.Result.Success)
        {
            string json = www.downloadHandler.text;

            Debug.Log(json);

            OnlineLeaderboardEntry[] entries =
                JsonHelper.FromJson<OnlineLeaderboardEntry>(json);

            //foreach (OnlineLeaderboardEntry entry in entries)
            //{
            //    Debug.Log(
            //        entry.player_name +
            //        " : " +
            //        entry.score
            //    );
            //}
            //leaderboardText.text = "ONLINE LEADERBOARD\n\n";
            leaderboardText.text = ""; //substitui o Loading... por string vazia 
            int rank = 1;

            foreach (OnlineLeaderboardEntry entry in entries)
            {
                leaderboardText.text +=
                    rank + ". " +
                    entry.player_name +
                    " - " +
                    entry.score +
                    "\n";

                rank++;
            }
        }
        else
        {
            Debug.Log("Error downloading leaderboard");
            Debug.Log(www.error);
        }
    }

}