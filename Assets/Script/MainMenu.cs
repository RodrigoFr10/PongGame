using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("JogoScene"); // Botao start. Carregar cena do jogo
    }

    public void OpenSettings()
    {
        Debug.Log("Settings clicked (not implemented yet)");
    }
}