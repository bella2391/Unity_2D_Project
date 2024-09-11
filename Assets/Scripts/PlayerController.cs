using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb2d;

    // ハロー・ワールド
    void Start()
    {
        // Rigidbody2D コンポーネントを取得します
        rb2d = GetComponent<Rigidbody2D>();

        // Rigidbody2D がアタッチされていない場合にエラーメッセージを出力します
        if (rb2d == null)
        {
            Debug.LogError("Rigidbody2D component is missing from this GameObject.");
        }
    }

    void Update()
    {
        if (rb2d != null)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector2 movement = new Vector2(moveHorizontal, moveVertical);
            rb2d.AddForce(movement * moveSpeed);
        }
    }
}
