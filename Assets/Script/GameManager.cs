using UnityEngine;
using TMPro;
using System;
using System.Security.Cryptography;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int playerScore = 0;
    public int enemyScore = 0;
    public int lvl = 1;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI debugText;
    public TextMeshProUGUI lvlText;
    public Transform ball;
    public Transform platformPlayer;
    public Transform platformEnemy;

    void Start()
    {
        UpdateScoreText();
    }

    public void PlayerScores()
    {
        playerScore++;
        UpdateScoreText();
        ResetBall();
        BallMovement ballScript = ball.GetComponent<BallMovement>();
        debugText.text = ballScript.speed+ "";
        //platformPlayer.transform.localScale += new Vector3(.5f, .1f, 0f);
        platformPlayer.GetComponent<PaddlePlayer>().increaseSize();
        platformEnemy.GetComponent<PaddleAI>().decreaseSize();
        if (platformEnemy.transform.localScale.x < .4f)
        {
            platformEnemy.GetComponent<PaddleAI>().nextLvl();
            lvl++;
            lvlText.text = "Level " + lvl;
        }
    }

    public void EnemyScores()
    {
        enemyScore++;
        UpdateScoreText();
        ResetBall();
        platformEnemy.GetComponent<PaddleAI>().increaseSize();
        platformPlayer.GetComponent<PaddlePlayer>().decreaseSize();

        if (platformPlayer.transform.localScale.x < 0.4f)
        {
            GameData.playerScore = playerScore; //saves score in global data
            GameData.enemyScore = enemyScore;


            LeaderboardManager.instance.AddScore( //Adiciona a pontuação ao usuario PLAYER
                "PLAYER",
                playerScore - enemyScore
            );

            SceneManager.LoadScene("GameOverScene"); // triggers game over scene
        }

    }

    void UpdateScoreText()
    {
        scoreText.text = playerScore + " | " + enemyScore;
    }

    void ResetBall()
    {
        ball.position = Vector3.zero;

        Rigidbody2D rb = ball.GetComponent<Rigidbody2D>();
        rb.linearVelocity = Vector2.zero;

        BallMovement ballScript = ball.GetComponent<BallMovement>();
        if (ballScript.speed > ballScript.startSpeed*1.1) 
        {
            ballScript.DecreaseSpeed();
        }
        else
        {
            ballScript.ResetSpeed();
        }


        // Random horizontal angle (never too small)
        float x = UnityEngine.Random.Range(0.4f, 1f);
        x *= UnityEngine.Random.value < 0.5f ? -1 : 1; // left or right

        // Choose UP or DOWN only
        float y = UnityEngine.Random.value < 0.5f ? 1f : -1f;

        Vector2 direction = new Vector2(x, y).normalized;

        rb.linearVelocity = direction * ballScript.speed;
    }
}