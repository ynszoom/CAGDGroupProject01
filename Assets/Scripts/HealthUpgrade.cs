using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Yasin Shilling
 * 4/21/2025
 * Determines how the maximum health booster works
 */
public class HealthUpgrade : MonoBehaviour
{
    PlayerController Health;
    PlayerController maxHealth;


    
    private void Awake()
    {
        Health = FindAnyObjectByType<PlayerController>();
    }

    
    
    private void OnTriggerEnter(Collider other)
    {//destroys the powerup
        Destroy(gameObject);
        //updates the player's new max health and refills health pool
        Health.maxHealth = Health.maxHealth + 100;
        Health.Health = Health.maxHealth;
    }
}
