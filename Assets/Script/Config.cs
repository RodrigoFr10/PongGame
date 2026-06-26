using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro; //textmesh pro

public class Config : MonoBehaviour
{
    public Slider sfxSlider;
    public Slider musicSlider;
    public TMP_Dropdown fpsDropdown;

    void Start()
    {
        GameSettings.sfxVolume = PlayerPrefs.GetFloat("SFXVolume", 1f); //load volume from player preferences
        GameSettings.musicVolume = PlayerPrefs.GetFloat("MusicVolume", 1f);

        sfxSlider.value = GameSettings.sfxVolume;
        musicSlider.value = GameSettings.musicVolume;

        switch (GameSettings.FPSLimit)
        {
            case 30:
                fpsDropdown.value = 0;
                break;

            case 40:
                fpsDropdown.value = 1;
                break;

            case 60:
                fpsDropdown.value = 2;
                break;

            default:
                fpsDropdown.value = 3;
                break;
        }

    }
    public void ChangeSFXVolume()
    {
        GameSettings.sfxVolume = sfxSlider.value;

        PlayerPrefs.SetFloat("SFXVolume", GameSettings.sfxVolume);
        PlayerPrefs.Save(); //salva volume nas preferencias
    }
    public void ChangeMusicVolume()
    {
        GameSettings.musicVolume = musicSlider.value;

        PlayerPrefs.SetFloat("MusicVolume", GameSettings.musicVolume);
        PlayerPrefs.Save();
    }

    public void ChangeFPS()
    {
        switch (fpsDropdown.value)
        {
            case 0:
                GameSettings.FPSLimit = 30;
                break;

            case 1:
                GameSettings.FPSLimit = 40;
                break;

            case 2:
                GameSettings.FPSLimit = 60;
                break;

            case 3:
                GameSettings.FPSLimit = -1;
                break;
        }

        Application.targetFrameRate = GameSettings.FPSLimit;

        PlayerPrefs.SetInt("FPSLimit", GameSettings.FPSLimit);
        PlayerPrefs.Save();
    }

    public void returnMenu()
    {
        SceneManager.LoadScene("MainMenuScene"); // Botao retorno. Retorna ao menu
    }
}