using System.IO;
using UnityEngine;

public class LeaderboardManager : MonoBehaviour
{
    public static LeaderboardManager instance;

    string path;
    public LeaderboardData leaderboard = new LeaderboardData();

    void Awake()
    {
        instance = this;

        path = Application.persistentDataPath + "/leaderboard.json";

        LoadLeaderboard();
    }

    public void AddScore(string playerName, int score)
    {
        LeaderboardEntry entry = new LeaderboardEntry();

        entry.playerName = playerName;
        entry.score = score;

        leaderboard.entries.Add(entry);

        // sort highest score first
        leaderboard.entries.Sort((a, b) => b.score.CompareTo(a.score));

        // keep only top 10
        if (leaderboard.entries.Count > 10)
        {
            leaderboard.entries.RemoveAt(10);
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