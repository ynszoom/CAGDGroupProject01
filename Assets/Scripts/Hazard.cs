using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* Yasin Shilling
 * 4/5/25
 * Controls Hazard collision detection/damage dealt 
 */

public class Hazard : MonoBehaviour
{
    public int damage = 15;
    public PlayerController Health;

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the player collided with this hazard, if so, deals damage to the player
        if (collision.gameObject.tag == "Player")
        {
            Health = collision.gameObject.GetComponent<PlayerController>();
            Health.TakeDamage(damage);
        }
    }
    //DO NOT TOUCH, THIS DOES NOTHING BUT KEEPS BREAKING THINGS WHEN REMOVED
    private void OnTriggerEnter(Collider other)
    {
        // Check if the player overlapped with this hazard, if so, deals damage to the player
        if (other.gameObject.GetComponent<PlayerController>())
        {
            other.gameObject.GetComponent<PlayerController>().LoseHealth();
        }
    }
}
