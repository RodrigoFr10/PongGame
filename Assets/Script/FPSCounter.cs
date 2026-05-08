using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FPSCounter : MonoBehaviour
{
    public TextMeshProUGUI fpsText;

    float deltaTime = 0.0f;

    void Update()
    {
        // smooth FPS calculation
        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;

        float fps = 1.0f / deltaTime;

        fpsText.text = "FPS: " + Mathf.Ceil(fps).ToString();
    }
}