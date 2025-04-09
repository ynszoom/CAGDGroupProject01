using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* Yasin Shilling
 * 4/1/25
 * Handles Enemy movement
 */

public class EnemyController : MonoBehaviour
{
    public float speed = 5;
    public Vector3 direction = Vector3.left;
    public Transform leftPoint;
    public Transform rightPoint;

    private Vector3 leftStart;
    private Vector3 rightStart;
    // Start is called before the first frame update
    void Start()
    {
        leftStart = leftPoint.position;
        rightStart = rightPoint.position;
    }

    // Update is called once per frame
    //void Update()
    //{
    //    EnemyMove();
    //}

    // FixedUpdate is called 50 times per second
    void FixedUpdate()
    {
        EnemyMove();
    }

    /// <summary>
    /// Move the Enemy left or right until it reaches the left/right point
    /// then changes it's direction
    /// </summary>
    private void EnemyMove()
    {
        transform.position += direction * speed * Time.deltaTime;

        // Checks if the Enemy moved past the right/left point on the x-axis
        if (transform.position.x >= rightStart.x || transform.position.x <= leftStart.x)
        {
            direction *= -1;
        }
    }
}
