using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
/*Yasin Shilling
 * 4/18/2025
 * Determines how lasers blasts behave
 */

public class Laser : MonoBehaviour
{
    [Header("Projectile Variables")]
    public float speed;
    public bool goingLeft;
    private Rigidbody rb;
    public GameObject Enemy;
    public int laserDamage;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.right * speed;
    }
    
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            //damages the enemy when hit by the laser
            other.gameObject.GetComponent<EnemyHealth>().DamageEnemy(laserDamage);
            Destroy(gameObject);
        }
        // Check if the colliding object's tag is NOT "Player"
        if (other.gameObject.tag != "Player")
        {
            // destroy s the laser after it hits something 
            Destroy(gameObject);
        }
       
    }

    
}




