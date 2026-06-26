using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausePanel;

    bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) //ao pressionar esc, pausa
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        pausePanel.SetActive(true);

        Time.timeScale = 0f;

        isPaused = true;
        AudioListener.pause = true; //pausar musica
    }

    public void ResumeGame()
    {
        pausePanel.SetActive(false);

        Time.timeScale = 1f;

        isPaused = false;
        AudioListener.pause = false;
    }

    public void ReturnToMenu()
    {
        Time.timeScale = 1f;
        AudioListener.pause = false;

        SceneManager.LoadScene("MainMenuScene");
    }
}