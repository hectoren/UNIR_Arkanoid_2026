using UnityEngine;

public class Brick : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            ScoreManager.Instance.AddScore(5);
            Destroy(gameObject);
        }
    }
}
