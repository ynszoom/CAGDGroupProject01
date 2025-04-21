using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
/*Yasin Shilling
4/19/2025
Scripts controls the player's laser gun
*/

public class Gun : MonoBehaviour
{
    [Header("Projectile Variables")]
    public bool goingLeft;
    [Header("Gun Variables")]
    public GameObject projectilePrefab;
    private float lastShotTime = 0f;
    private float fireRate = 1f; // Time between shots in seconds
    public Transform firingPoint;
    public GameObject Laser;
   
    // Update is called once per frame
    void Update()
    {//shoots the gun
        if (Input.GetKey(KeyCode.W) && Time.time > lastShotTime + fireRate)
        {
            // Limits fire rate of gun
            lastShotTime = Time.time;
            Fire();
        }
        
        
    }
    private void Fire()
    {
        Instantiate(Laser, firingPoint.position,transform.rotation);
    }
    
}
