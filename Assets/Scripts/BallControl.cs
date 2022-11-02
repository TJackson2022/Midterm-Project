using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEditor;
//using UnityEditor.AnimatedValues;
using UnityEngine;
using UnityEngine.Windows;

public class BallControl : MonoBehaviour
{
    public Rigidbody ballrb;
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
        ballrb.gameObject.transform.position = hide;
        yield return new WaitForSeconds(2);
        ballrb.velocity = Vector3.zero;
        ballrb.gameObject.transform.position = Vector3.zero;

        //float randomNumber = Random.Range(0f, 6f);
        float randomNumber = Random.Range(0f, 3f);
        //Debug.Log(randomNumber);

        /*if (randomNumber <= 1)
        {
            ballrb.AddForce(motionLeft);
        }
        else if (randomNumber > 1 && randomNumber <= 2)
        {
            ballrb.AddForce(motionRight);
        }
        else if (randomNumber > 2 && randomNumber <= 3)
        {
            ballrb.AddForce(motionUpLeft);
        }
        else if (randomNumber > 3 && randomNumber <= 4)
        {
            ballrb.AddForce(motionUpRight);
        }
        else if (randomNumber > 4 && randomNumber <= 5)
        {
            ballrb.AddForce(motionDownLeft);
        }
        else if (randomNumber > 5 && randomNumber <= 6)
        {
            ballrb.AddForce(motionDownRight);
        }*/

        if (randomNumber <= 1)
        {
            ballrb.AddForce(motionLeft);
        }
        else if (randomNumber > 1 && randomNumber <= 2)
        {
            ballrb.AddForce(motionUpLeft);
        }
        else if (randomNumber > 2 && randomNumber <= 3)
        {
            ballrb.AddForce(motionDownLeft);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Boing");

        if (collision.collider.CompareTag("Player"))
        {
            //Debug.Log("Boing2");
            ballrb.velocity = new UnityEngine.Vector2(ballrb.velocity.x, ((ballrb.velocity.y / 2) + (collision.collider.gameObject.GetComponent<CharacterController>().velocity.y / 3)));
        }
        
    }
}
