using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed;
    public float speedIncrease = 1f;

    public float startSpeed;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        startSpeed = speed; // store the default speed

        Vector2 direction = new Vector2(1, 1).normalized;
        rb.linearVelocity = direction * speed;
    }

    public void ResetSpeed()
    {
        speed = startSpeed;
    }
    public void DecreaseSpeed()
    {
        speed = speed*0.9f;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "paddle_down")
        {
            speed += speedIncrease;
            rb.linearVelocity = rb.linearVelocity.normalized * speed;
        }
    }
    void Update()
    {
        if (transform.position.y < -9)
        {
            FindObjectOfType<GameManager>().EnemyScores();
        }

        if (transform.position.y > 9)
        {
            FindObjectOfType<GameManager>().PlayerScores();
        }
    }

}