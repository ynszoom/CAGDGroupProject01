using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* Yasin Shilling
 * 4/1/25
 * Controls player movement 
 */

public class PlayerController : MonoBehaviour
{

    public float speed = 15;
    public float jumpForce = 10;
    public int coins = 0;
    public int lives;
    public int maxLives = 3;
    

    private Rigidbody rb;
    private Vector3 respawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        lives = maxLives;
        rb = GetComponent<Rigidbody>();
        respawnPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // FixedUpdate is called 50 times per second
    void FixedUpdate()
    {
        Move();
    }

    /// <summary>
    /// Check for player left/right input and moves left/right
    /// </summary>
    private void Move()
    {
        // Check for inputs, then performs the corresponding action
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            // Move right
            //transform.position += Vector3.right * speed * Time.deltaTime;
            rb.MovePosition(transform.position + Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            // Move left
            //transform.position += Vector3.left * speed * Time.deltaTime;
            rb.MovePosition(transform.position + Vector3.left * speed * Time.deltaTime);
        }
    }

    /// <summary>
    /// Checks for player jump input and 
    /// </summary>
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && OnGround())
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    /// <summary>
    /// Checks with a raycast for if the player is on the ground
    /// </summary>
    /// <returns>Whether or not the player is on the ground</returns>
    private bool OnGround()
    {
        bool onGround = false;

        RaycastHit hit;

        // Draws a ray downward 1.2 units from the player's center
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 1.2f)) onGround = true;

        return onGround;
    }

    /// <summary>
    /// Reduces player's lives by 1 and respawns if lives remain
    /// </summary>
    public void LoseLife()
    {
        // Reduces player's lives
        lives--;

        // Check if lives > 0, respawn if true, else Game Over
        if (lives > 0)
        {
            transform.position = respawnPoint;
        }
        else
        {
            print("GAME OVER");
        }
    }
}
