using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundary : MonoBehaviour {
    public LayerMask playerBallLayer, centerBallLayer;
    private int playerBallLayerID, centerBallLayerID, boundaryLayerID;
    private bool firstCollided;

    void Start() {
        // レイヤーIDの取得
        playerBallLayerID = LayerMask.NameToLayer("PlayerBall");
        centerBallLayerID = LayerMask.NameToLayer("CenterBall");
        boundaryLayerID = LayerMask.NameToLayer("Boundary");
        // レイヤーIDの確認（デバッグ用）
        Debug.Log("PlayerBall Layer ID: " + playerBallLayerID);
        Debug.Log("CenterBall Layer ID: " + centerBallLayerID);
        Debug.Log("Boundary Layer ID: " + boundaryLayerID);

        // 最初だけレイヤー間の衝突判定を無効化
        Physics2D.IgnoreLayerCollision(playerBallLayerID, boundaryLayerID, false);
        Physics2D.IgnoreLayerCollision(centerBallLayerID, boundaryLayerID, true);
        // 衝突判定を無効化するコルーチンを開始
        // StartCoroutine(DisableCollisionInitially());

        //firstCollided = false;
    }
    
    // Update is called once per frame
    void Update() { 
        
    }

    // 初期化のために少し待つコルーチン
    /*private IEnumerator DisableCollisionInitially() {
        yield return new WaitForSeconds(0.1f);  // 0.1秒待機

        // 真ん中のボールと境界線の衝突を無効化
        Physics2D.IgnoreLayerCollision(centerBallLayerID, boundaryLayerID, true);
    }*/

    private void OnCollisionEnter2D(Collision2D collision) {

        int collidedLayer = collision.gameObject.layer;

        /*if (collidedLayer == playerBallLayerID && !firstCollided) {
            firstCollided = true; // 初衝突のフラグをtrueにセット
            Debug.Log("プレイヤーボールが真ん中のボールに触れました。衝突判定を有効化します。");

            // 真ん中のボールと境界線の衝突を有効化
            Physics2D.IgnoreLayerCollision(centerBallLayerID, boundaryLayerID, false);
        }*/

        /*if (collidedLayer == playerBallLayerID) {
            // プレイヤーのボールが境界線に衝突した場合、通過させない
            Debug.Log("Player ball hit the boundary!");
            // プレイヤーのボールと境界線は衝突するように設定
            Physics2D.IgnoreLayerCollision(playerBallLayerID, boundaryLayerID, false);
            // 必要に応じて反応を制御
        } else if (collidedLayer == centerBallLayerID) {
            // 中央のボールが境界線に衝突した場合、通過させる
            Debug.Log("Center ball passed the boundary.");
            // 中央のボールと境界線は衝突しないように設定
            Physics2D.IgnoreLayerCollision(centerBallLayerID, boundaryLayerID, true);
        }*/
    }
}
