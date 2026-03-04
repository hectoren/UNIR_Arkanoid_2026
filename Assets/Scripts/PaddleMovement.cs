using UnityEngine;
using UnityEngine.InputSystem;

public class PaddleMovement : MonoBehaviour
{
    [SerializeField] public float speed = 10f;
    private Rigidbody2D rb;
    private float moveInput;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<float>();
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2 (moveInput * speed, rb.linearVelocity.y);
    }
}
