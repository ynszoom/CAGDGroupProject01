using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* Yasin Shilling
 * 4/1/25
 * Dictates how portals work
 */

public class Portal : MonoBehaviour
{
    public Transform teleportPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // Sets the position of the touched object to the teleport point
        other.transform.position = teleportPoint.position;

        
    }
}
