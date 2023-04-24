using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    // amount of damage the hazard does
    public int hazardDamage;

    private void OnCollisionEnter2D(Collision2D collisionData)
    {
        Collider2D objectCollide = collisionData.collider;


        //get the player health script attached to object if there is one
        PlayerHealth player = objectCollide.GetComponent<PlayerHealth>();


        // checks if the playerhealth is attached i.e is this the player character checker
        if (player != null)
        {
            player.changeHealth(-hazardDamage);
        }

    }
}
