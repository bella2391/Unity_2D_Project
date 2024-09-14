using UnityEngine;

public class goll : MonoBehaviour
{
    public GameObject ballPrefab; // ボールのプレハブ
    public Transform spawnPoint;  // ボールを生成する位置
    
    void Start()
    {
        // 初期化処理があればここに書きます
    }

    void Update()
    {
        // 更新処理があればここに書きます
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 衝突したオブジェクトの名前が "left_goal" の場合
        if (collision.gameObject.name == "central_ball")
        {


           




            ///Destroy(collision.gameObject); // 衝突したボールを破棄
           /// SpawnBall(); // 新しいボールを spawnPoint の位置に生成
        }
    }

    void SpawnBall()
    {
        if (ballPrefab != null && spawnPoint != null)
        {
            // ボールを生成
            Instantiate(ballPrefab, spawnPoint.position, Quaternion.identity);
            Debug.Log("Ball spawned at: " + spawnPoint.position);
        }
        else
        {
            Debug.LogWarning("Ball prefab or spawn point is not assigned.");
        }
    }
}
