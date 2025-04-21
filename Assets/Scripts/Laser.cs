using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
/*Yasin Shilling
 * 4/18/2025
 * Determines how lasers behave
 */





public class Laser : MonoBehaviour
{
    [Header("Projectile Variables")]
    public float speed;
    public bool goingLeft;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.right * speed;
    }
    void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object's tag is NOT "Player"
        if (other.gameObject.tag != "Player")
        {
            // destroy the object  to remove it)
            Destroy(gameObject);
        }
    }


}




