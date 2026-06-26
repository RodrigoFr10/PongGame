using UnityEngine;

public class GameSettings : MonoBehaviour
{
    public static float sfxVolume = 1f;
    public static float musicVolume = 1f;

    public static int FPSLimit = 60;

    void Awake()
    {
        sfxVolume = PlayerPrefs.GetFloat("SFXVolume", 1f);
        musicVolume = PlayerPrefs.GetFloat("MusicVolume", 1f);

        FPSLimit = PlayerPrefs.GetInt("FPSLimit", 60);

        QualitySettings.vSyncCount = 0; //disable Vsync
        Application.targetFrameRate = FPSLimit;
    }
}