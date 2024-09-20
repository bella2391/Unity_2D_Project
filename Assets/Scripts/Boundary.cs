using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour {
    //public LayerMask playerBallLayer, centerBallLayer;
    private int playerBallLayerID, centerBallLayerID, boundaryLayerID;

    void Start() {
        // レイヤーIDの取得
        playerBallLayerID = LayerMask.NameToLayer("PlayerBall");
        centerBallLayerID = LayerMask.NameToLayer("CenterBall");
        boundaryLayerID = LayerMask.NameToLayer("Boundary");

        Physics2D.IgnoreLayerCollision(playerBallLayerID, boundaryLayerID, false);
        Physics2D.IgnoreLayerCollision(centerBallLayerID, boundaryLayerID, true);
    }
    
    // Update is called once per frame
    void Update() { 
        
    }
}
