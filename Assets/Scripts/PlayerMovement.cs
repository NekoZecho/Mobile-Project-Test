using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]
    float moveSpeed = 5f;
    [SerializeField]
    InputActionReference moveActionRef;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 moveDir = moveActionRef.action.ReadValue<Vector2>();

        rb.linearVelocity = moveDir * moveSpeed;
    }
}
