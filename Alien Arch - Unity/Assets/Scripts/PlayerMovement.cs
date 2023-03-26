using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D physicsBody = null;


    public float speed = 1;






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





    private void Awake()
    {
        physicsBody = GetComponent<Rigidbody2D>();
    }
}
