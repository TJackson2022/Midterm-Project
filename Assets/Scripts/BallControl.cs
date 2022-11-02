using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.AnimatedValues;
using UnityEngine;
using UnityEngine.Windows;

public class BallControl : MonoBehaviour
{
    public Rigidbody ball;
    public Vector2 motionLeft = Vector2.left;
    public Vector2 motionRight = Vector2.right;

    // Start is called before the first frame update
    void Start()
    {
        int randomNumber = (int) Random.Range(0f, 1f);
        if (randomNumber <= 0.5f)
        {
            ball.AddForce(motionLeft);
        }
        else// if (randomNumber > 0.5f)
        {
            ball.AddForce(motionRight);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*void OnCollisionExit(Collision collision)
    {
        //Debug.Log("Boing");

        //float velocityY = ball.velocity.y;
        //velocityY = velocityY / 2 + collision.collider.attachedRigidbody.velocity.y / 3;
        
        
        if (collision.collider.CompareTag("Player"))
        {
            //Debug.Log("Boing2");
            //ball.velocity.Set(ball.velocity.x, ball.velocity.y / 2 + collision.collider.attachedRigidbody.velocity.y / 3, ball.velocity.z);
            ball.velocity.Set(ball.velocity.x, ((ball.velocity.y / 2) + (collision.collider.transform.up.y / 3)), ball.velocity.z);
        }
        
    }*/
}
