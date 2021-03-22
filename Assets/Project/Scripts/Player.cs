using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Ball ball;
    public GameObject playerCamera;
    public float ballDistance = 2f;
    public float ballThrowingForce = 5f;

    public bool holdingBall = true;

    void Start()
    {
        ball.GetComponent<Rigidbody>().useGravity = false;
    }

    
    void Update()
    {
        if (holdingBall){
            ball.transform.position = playerCamera.transform.position + playerCamera.transform.forward * ballDistance;
            if (Input.GetMouseButtonDown(0)){
                holdingBall = false;
                ball.ActiveTrail();
                ball.GetComponent<Rigidbody>().useGravity = true;
                ball.GetComponent<Rigidbody>().AddForce(playerCamera.transform.forward * ballThrowingForce);
            }
        }
    }
}
