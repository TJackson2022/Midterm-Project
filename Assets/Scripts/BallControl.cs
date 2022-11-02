using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEditor;
//using UnityEditor.AnimatedValues;
using UnityEngine;
using UnityEngine.Windows;

public class BallControl : MonoBehaviour
{
    public Rigidbody ball;
    public float ballSpeed = 500f;
    Vector2 motionLeft = Vector2.left;
    Vector2 motionRight = Vector2.right;
    Vector2 motionUpLeft;
    Vector2 motionUpRight;
    Vector2 motionDownLeft;
    Vector2 motionDownRight;
    Vector3 hide = new(0, 0, 500);

    // Start is called before the first frame update
    void Start()
    {
        motionLeft.Set(-ballSpeed, 0);
        motionRight.Set(ballSpeed, 0);
        motionUpLeft.Set(-ballSpeed, ballSpeed/2);
        motionUpRight.Set(ballSpeed, ballSpeed/2);
        motionDownLeft.Set(-ballSpeed, -ballSpeed/2);
        motionDownRight.Set(ballSpeed, -ballSpeed/2);

        StartCoroutine(NewRoundLaunch());
    }

    public void NewRoundReset()
    {
        StartCoroutine(NewRoundLaunch());
    }

    IEnumerator NewRoundLaunch()
    {
        ball.gameObject.transform.position = hide;
        yield return new WaitForSeconds(2);
        ball.velocity = Vector3.zero;
        ball.gameObject.transform.position = Vector3.zero;

        //float randomNumber = Random.Range(0f, 6f);
        float randomNumber = Random.Range(0f, 3f);
        Debug.Log(randomNumber);

        /*if (randomNumber <= 1)
        {
            ball.AddForce(motionLeft);
        }
        else if (randomNumber > 1 && randomNumber <= 2)
        {
            ball.AddForce(motionRight);
        }
        else if (randomNumber > 2 && randomNumber <= 3)
        {
            ball.AddForce(motionUpLeft);
        }
        else if (randomNumber > 3 && randomNumber <= 4)
        {
            ball.AddForce(motionUpRight);
        }
        else if (randomNumber > 4 && randomNumber <= 5)
        {
            ball.AddForce(motionDownLeft);
        }
        else if (randomNumber > 5 && randomNumber <= 6)
        {
            ball.AddForce(motionDownRight);
        }*/

        if (randomNumber <= 1)
        {
            ball.AddForce(motionLeft);
        }
        else if (randomNumber > 1 && randomNumber <= 2)
        {
            ball.AddForce(motionUpLeft);
        }
        else if (randomNumber > 2 && randomNumber <= 3)
        {
            ball.AddForce(motionDownLeft);
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
