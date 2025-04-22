using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* Yasin Shilling
 * 4/21/2025
 * Determines how the laser/gun powerup works
 */


public class PowerUp : MonoBehaviour
{
    public GameObject Laser;
    public GameObject Player_Character;
    public GameObject HLaser;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            // Activate the power-up effect (e.g., increase bullet speed)
            // Here, we're simply replacing the bullet prefab
            Player_Character.GetComponent<Gun>().Laser = HLaser;

            // Destroy the power-up
            Destroy(gameObject);
        }
    }
}
