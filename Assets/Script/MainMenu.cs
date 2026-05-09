using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro; //textmesh pro

public class MainMenu : MonoBehaviour
{
    public TMP_InputField nameInput;
    public void StartGame()
    {

        
        if (nameInput.text != "") //Se o campo nome estiver vazio, padronize o nome do jogador para PLAYER
        {
            //PlayerData.playerName = nameInput.text; //salva o nome escrito no campo
            PlayerData.playerName = nameInput.text.Substring( //salva o nome escrito no campo com limite de 12 letras
                0,
                Mathf.Min(nameInput.text.Length, 12)
            );
        }
        else
        {
            PlayerData.playerName = "PLAYER";
        }

        SceneManager.LoadScene("jogoScene"); // Botao start. Carregar cena do jogo
        
    }

    public void OpenSettings()
    {
        Debug.Log("Settings clicked (not implemented yet)");
    }
}