using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.AnimatedValues;
using UnityEngine;
using UnityEngine.Windows;

public class BallControl : MonoBehaviour
{
    public Rigidbody ball;
    public Vector3 motionLeft = Vector3.left;
    public Vector3 motionRight = Vector3.right;

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

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Boing");

        //Rigidbody velocityY = Rigidbody.
    }
}
