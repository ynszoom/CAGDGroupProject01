using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Yasin Shilling
 * 4/20/2025
 * Determines how health orbs/pickups work
 */

public class HealthPickups : MonoBehaviour
{
    PlayerController Health;
    public int healthRestored = 30;

    private void Awake()
    {
        Health = FindAnyObjectByType<PlayerController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Health.Health < Health.maxHealth)
        { 
        Destroy(gameObject);
            Health.Health = Health.Health + healthRestored;

        }
    }


}
