using TMPro;
using UnityEngine;

public class UserStatus : MonoBehaviour
{
    public static UserStatus instance;

    public TextMeshProUGUI statusText;

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
        }
    }

    void Update()
    {
        if (PlayerData.isLoggedIn)
        {
            statusText.text = PlayerData.playerName;
        }
        else
        {
            statusText.text = "Player";
        }
    }

    void Start()
    {
        Refresh();
    }

    public void Refresh()
    {
        if (PlayerData.isLoggedIn)
        {
            Debug.Log("UserNameScript sees: " + PlayerData.playerName);
            statusText.text = PlayerData.playerName;
        }
        else
        {
            statusText.text = "Guest";
        }
    }
}