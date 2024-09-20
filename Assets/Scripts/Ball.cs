using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public Transform spawnPoint;  // ボールを生成する位置
    private Rigidbody2D rb;
    
    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        
    }
    private void OnCollisionEnter2D(Collision2D collision) {

        if (collision.gameObject.name == "goal_left") { // 左にゴールしたとき
        
            transform.position = spawnPoint.position; // 位置を０００に変更

            Vector2 movement = new Vector2(0, 0) ;
            rb.velocity = movement;
        }

        if (collision.gameObject.name == "goal_right") { // 右にゴールしたとき
        
            transform.position = spawnPoint.position; // 位置を０００に変更

            Vector2 movement = new Vector2(0, 0) ;
            rb.velocity = movement;
        }
    }
}
