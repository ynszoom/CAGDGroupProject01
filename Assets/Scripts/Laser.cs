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


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            goingLeft = true;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            goingLeft = false;
        }

        
    }
    private void FixedUpdate()
    {
        if (goingLeft == true)
        {
            transform.position += speed * Vector3.left * Time.deltaTime;
        }
        else
        {
            transform.position += speed * Vector3.right * Time.deltaTime;
        }
    }
}




