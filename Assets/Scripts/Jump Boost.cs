using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Yasin Shilling
 * 4/21/2025
 * Dictates how the jump upgrade works
 */
public class JumpBoost : MonoBehaviour
{
    PlayerController jumpforce;

    // Start is called before the first frame update
    private void Awake()
    {
        jumpforce = FindAnyObjectByType<PlayerController>();
    }

    
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        jumpforce.jumpForce = jumpforce.jumpForce * 2;
    }
}
