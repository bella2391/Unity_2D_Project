using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour {
    public Transform spawnPoint;
    public float threshold = 0.1f;
    private Rigidbody2D rb;
    private static bool firstTouch = false;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {

    }
    private void OnCollisionEnter2D(Collision2D collision) {

        GameObject collisioner = collision.gameObject;

        if (collisioner.CompareTag("playerball")) {
            Ball.firstTouch = true;
        }

        if (Ball.firstTouch) {
            Debug.Log("0");
            if (collisioner.CompareTag("playerball")) {
                Debug.Log("1");
                if (IsCenterBallTouchingBars()) {
                    Debug.Log("playerball is collided by centerball under centerball colliding bothsides of bar");
                }
            }
        }

        if (collisioner.CompareTag("goal")) {

            Ball.firstTouch = false;

            transform.position = spawnPoint.position;

            Vector2 movement = new Vector2(0, 0);
            rb.velocity = movement;
        }
    }

    bool IsCenterBallTouchingBars() {
        GameObject[] bars = GameObject.FindGameObjectsWithTag("bar_bothsides");

        float minDistance = float.MaxValue;

        foreach (GameObject bar in bars) {
            float distance = Vector2.Distance(this.gameObject.transform.position, bar.transform.position);
            if (distance < minDistance) {
                minDistance = distance;
            }
        }

        Debug.Log(minDistance);

        return minDistance <= threshold;
    }
}
