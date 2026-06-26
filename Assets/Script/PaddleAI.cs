using UnityEngine;

public class PaddleAI : MonoBehaviour
{
    public Transform ball;
    public float speed;
    public float startWid;
    public float startHei;
    
    public float leftLimit = -6f;
    public float rightLimit = 6f;
    public float maxWidth = 11.2f;

    SpriteRenderer sr;
    public float colorReturnSpeed = 1f;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (ball == null) return;

        float direction = ball.position.x - transform.position.x;

        if (Mathf.Abs(direction) > 0.1f)
        {
            float move = Mathf.Sign(direction);
            transform.Translate(Vector2.right * move * speed * Time.deltaTime);
        }

        float clampedX = Mathf.Clamp(transform.position.x, leftLimit, rightLimit);
        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);

        sr.color = Color.Lerp(sr.color, Color.white, colorReturnSpeed * Time.deltaTime); //return to color white
    }
    public void increaseSize()
    {
        if (transform.localScale.x >= maxWidth) //se o tamanho do inimigo for >= ao limite, não cresce
        {
            return;
        }

        transform.localScale += new Vector3(startWid * 0.05f, startHei * 0.05f, 0f);
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
    public void resetSize()
    {
        transform.localScale = new Vector3(startWid, startHei, 0f);
        
        leftLimit = -6.4f;
        rightLimit = -leftLimit;
    }
    public void nextLvl()
    {
        resetSize();
        speed += speed*0.3f;
        sr.color = new Color(1f, 0f, 1f);
    }
}