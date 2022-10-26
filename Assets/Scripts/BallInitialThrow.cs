using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.AnimatedValues;
using UnityEngine;
using UnityEngine.Windows;

public class BallInitialThrow : MonoBehaviour
{
    public Rigidbody ball;
    public Vector3 motion = Vector3.left;

    // Start is called before the first frame update
    void Start()
    {
        ball.AddForce(motion);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
