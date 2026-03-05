using System;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] public float speed = 8f;

    public void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        LaunchBall();
    }

    void LaunchBall()
    {
        Vector2 direction = new Vector2(1, 1).normalized;
        rb.linearVelocity = direction * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 v = rb.linearVelocity;

        if (Mathf.Abs(v.y) < 1f)
        {
            v.y = 1f * Mathf.Sign(v.y == 0 ? 1 : v.y);
        }

        rb.linearVelocity = v.normalized * speed;
    }
}
