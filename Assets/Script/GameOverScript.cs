using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI finalScoreText;

    void Start()
    {
        int finalScore = GameData.playerScore - GameData.enemyScore;
        finalScoreText.text = "Final Score: " + finalScore;
    }

    public void VoltarAoMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}