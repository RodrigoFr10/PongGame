using TMPro;
using UnityEngine;

public class LeaderboardUI : MonoBehaviour
{
    public TextMeshProUGUI leaderboardText;

    void Start()
    {
        leaderboardText.text = "";

        foreach (LeaderboardEntry entry in LeaderboardManager.instance.leaderboard.entries)
        {
            leaderboardText.text +=
                entry.playerName +
                " - " +
                entry.score +
                "\n";
        }
    }
}