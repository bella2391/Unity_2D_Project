using UnityEngine;
using System.Collections;

public class goll : MonoBehaviour
{
    public GameObject ballPrefab; // ボールのプレハブ
    public Transform spawnPoint;  // ボールを生成する位置

    void Start()
    {
        // ボールのプレハブは非表示にしない
        // ゲーム開始時にボールを spawnPoint の位置に生成
        SpawnBall();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 衝突したオブジェクトの名前が "central_ball" の場合
        if (collision.gameObject.name == "central_ball")
        {
            Destroy(collision.gameObject); // 衝突したボールを破棄
            StartCoroutine(SpawnBallAfterDelay(0.1f)); // 少し遅れてボールを生成
        }
    }

    IEnumerator SpawnBallAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay); // 遅延を待つ
        SpawnBall(); // ボールを生成
    }

    void SpawnBall()
    {
        if (ballPrefab != null && spawnPoint != null)
        {
            GameObject newBall = Instantiate(ballPrefab, spawnPoint.position, Quaternion.identity);
            // ボールの位置を確認
            Debug.Log("Ball spawned at: " + spawnPoint.position);
        }
        else
        {
            Debug.LogWarning("Ball prefab or spawn point is not assigned.");
        }
    }
}
