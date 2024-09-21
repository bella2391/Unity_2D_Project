using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour {
    private int playerBallLayerID, centerBallLayerID, boundaryLayerID;

    void Start() {
        playerBallLayerID = LayerMask.NameToLayer("PlayerBall");
        centerBallLayerID = LayerMask.NameToLayer("CenterBall");
        boundaryLayerID = LayerMask.NameToLayer("Boundary");

        Physics2D.IgnoreLayerCollision(playerBallLayerID, boundaryLayerID, false);
        Physics2D.IgnoreLayerCollision(centerBallLayerID, boundaryLayerID, true);
    }
    
    void Update() { 
        
    }
}
