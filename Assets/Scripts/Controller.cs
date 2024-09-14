using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public string horizontalInputAxis = "Horizontal";
    public string verticalInputAxis = "Vertical";

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveX = Input.GetAxis(horizontalInputAxis);
        float moveY = Input.GetAxis(verticalInputAxis);

        Vector2 movement = new Vector2(moveX, moveY) * moveSpeed;
        rb.velocity = movement;
    }
}
