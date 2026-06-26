using System.IO;
using UnityEngine;

public class LeaderboardManager : MonoBehaviour
{
    public static LeaderboardManager instance;

    string path;
    public LeaderboardData leaderboard = new LeaderboardData();

    void Awake() //salva os dados de leaderboard em C:\Users\Home\AppData\LocalLow\DefaultCompany\pongGame, no arquivo json
    {
       
        if (instance == null)
        {
            instance = this;

            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        

        path = Application.persistentDataPath + "/leaderboard.json"; 

        LoadLeaderboard();
    }

    public void AddScore(string playerName, int score)
    {
        // Prevent empty names
        if (string.IsNullOrWhiteSpace(playerName))
        {
            playerName = "Player";
            return;
        }

        //if (!PlayerData.isLoggedIn)
        //{
        //    return;
        //}

        // Try to find existing player
        LeaderboardEntry existingEntry = leaderboard.entries.Find(
            entry => entry.playerName == playerName
        );

        // If player already exists
        if (existingEntry != null)
        {
            // Only replace if new score is higher
            if (score > existingEntry.score)
            {
                existingEntry.score = score;
            }
        }
        else
        {
            // Add new player
            LeaderboardEntry newEntry = new LeaderboardEntry();

            newEntry.playerName = playerName;
            newEntry.score = score;

            leaderboard.entries.Add(newEntry);
        }

        // Sort highest to lowest
        leaderboard.entries.Sort((a, b) => b.score.CompareTo(a.score));

        // Keep only top 10
        if (leaderboard.entries.Count > 10)
        {
            leaderboard.entries.RemoveRange(10, leaderboard.entries.Count - 10);
        }

        SaveLeaderboard();
    }

    void SaveLeaderboard()
    {
        string json = JsonUtility.ToJson(leaderboard, true);

        File.WriteAllText(path, json);
    }

    void LoadLeaderboard()
    {
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);

            leaderboard = JsonUtility.FromJson<LeaderboardData>(json);
        }
    }
}