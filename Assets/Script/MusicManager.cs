using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    public static MusicManager instance;

    private AudioSource audioSource;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;

            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        audioSource = GetComponent<AudioSource>();
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode) //musica toca apenas durante o jogo
    {
        if (scene.name == "JogoScene")
        {
            //audioSource.UnPause();
            audioSource.Stop();
            audioSource.Play();
        }
        else
        {
            audioSource.Pause();
        }
    }

    void Update()
    {
        audioSource.volume = GameSettings.musicVolume;
    }
}