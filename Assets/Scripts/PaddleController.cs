using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    // Reference to the character controller that handles our collisions and movement
    public CharacterController controller;

    // Speed of the player
    public float speed = 1f;

    // Update is called once per frame
    void Update()
    {
        Vector2 currentPos = transform.position;
        Vector2 motion = Vector2.zero;

        // Step 2 get player input
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        // Step 3 set new position based on input and speed
        // The new value of currentpos in x will be its curerent value, plus the speed
        // multiplied by the input (-1 or 1) and time.deltaTime
        currentPos.x = currentPos.x + speed * inputX * Time.deltaTime;

        // Step 4 repeat the same with Z
        currentPos.y = currentPos.y + speed * inputY * Time.deltaTime;

        // This will get us the vector of our movement, instead of the new position
        // motion.x = transform.forward.normalized.x * speed * inputX * Time.deltaTime;
        // motion.z = transform.forward.normalized.z * speed * inputY * Time.deltaTime;

        motion = (transform.up * speed * inputY * Time.deltaTime) + (transform.right * speed * inputX * Time.deltaTime);

        // Step 5 assign new position
        // transform.position = currentPos;

        // Instead of moving it normally, we can use the character controller for motion
        controller.Move(motion);
    }
}
