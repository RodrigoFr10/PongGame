using System.Security.Cryptography;
using UnityEngine;

public class PaddlePlayer : MonoBehaviour
{
    public float speed;
    public float startWid;
    public float startHei;
    // horizontal limits
    public float leftLimit = -6.4f;
    public float rightLimit = 6.4f;

    SpriteRenderer sr;
    public float colorReturnSpeed = 1f;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>(); //grab the paddle’s SpriteRenderer once so we don’t search every frame.
    }
    void Update()
    {
        float move = 0;

        if (Input.GetKey(KeyCode.A))
        {
            move = -1;
        }

        if (Input.GetKey(KeyCode.D))
        {
            move = 1;
        }
        transform.Translate(Vector2.right * move * speed * Time.deltaTime);

        // clamp position so paddle stays inside arena
        float clampedX = Mathf.Clamp(transform.position.x, leftLimit, rightLimit);

        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);
        // grow paddle horizontally over time
        //transform.localScale += new Vector3(1f * Time.deltaTime, 0f, 0f);

        sr.color = Color.Lerp(sr.color, Color.white, colorReturnSpeed * Time.deltaTime); //return to color white
    }
    public void increaseSize()
    {
        transform.localScale += new Vector3(startWid*0.05f, startHei*0.05f, 0f);
        leftLimit += startWid * 0.025f;
        rightLimit = -leftLimit;

        sr.color = new Color(0f, 1f, 0f); //RGB where 1 equals 255
    }


    public void decreaseSize()
    {
        transform.localScale -= new Vector3(startWid * 0.1f, startHei * 0.1f, 0f);
        leftLimit -= startWid * 0.05f;
        rightLimit = -leftLimit;

        sr.color = new Color(1f, 0f, 0f);

    }
}