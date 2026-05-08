using UnityEngine;

public class GameSettings : MonoBehaviour
{
    public int FPSLimit;
    void Awake()
    {
        QualitySettings.vSyncCount = 0; // disable VSync
        Application.targetFrameRate = FPSLimit;
    }
}
