using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* Yasin Shilling
 * 4/1/25
 * Controls Hazard collision detection/damage dealt 
 */

public class Hazard : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the player collided with this hazard, if so, deals damage to the player
        if (collision.gameObject.GetComponent<PlayerController>())
        {
            collision.gameObject.GetComponent<PlayerController>().LoseHealth();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player overlapped with this hazard, if so, deals damage to the player
        if (other.gameObject.GetComponent<PlayerController>())
        {
            other.gameObject.GetComponent<PlayerController>().LoseHealth();
        }
    }
}
