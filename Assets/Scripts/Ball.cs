using UnityEngine;

public class Ball : MonoBehaviour

{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 StartPosition;
    private float Startx = 0f;
    private float Starty = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        LaunchBall();
    }
    public void LaunchBall()
    {
        float x = Random.Range(0, 2) == 0 ? -1f : 1f;
        float y = Random.Range(0, 2) == 0 ? -1f : 1f;

        Vector2 direction = new Vector2(x, y).normalized;
        rb.linearVelocity = direction * speed;
    }
    public void ResetBall()
    {
        
        Vector2 position = new Vector2(Startx, Starty);
        transform.position = position;
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ResetBall();
        LaunchBall();
    }
}
