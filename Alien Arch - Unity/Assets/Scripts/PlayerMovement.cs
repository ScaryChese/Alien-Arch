using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D physicsBody = null;


    public Collider2D groundSensor = null;
    public LayerMask grounLayer = 0;

    public float speed = 1;

    public float jumpSpeed = 10;








    /// <summary>
    /// make a variable to hold velocity and get current velocity from the physcics component
    /// -1 velocity = move left
    /// </summary>
    public void MoveLeft()
    {
        Vector2 newVelocity = physicsBody.velocity;

        newVelocity.x = -speed;

        physicsBody.velocity = newVelocity;
    }

    public void MoveRight()
    {
        Vector2 newVelocity = physicsBody.velocity;

        newVelocity.x = speed;

        physicsBody.velocity = newVelocity;
    }

    public void Jump()
    {
        if (groundSensor.IsTouchingLayers(grounLayer))
        {
            Vector2 newVelocity = physicsBody.velocity;

            newVelocity.y = jumpSpeed;

            physicsBody.velocity = newVelocity;
        }
    }




    private void Awake()
    {
        physicsBody = GetComponent<Rigidbody2D>();
    }
}
