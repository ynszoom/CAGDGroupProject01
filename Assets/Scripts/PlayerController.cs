using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* Yasin Shilling
 * 4//25
 * Controls player movement 
 */

public class PlayerController : MonoBehaviour
{
    
    public float speed = 15;
    public float jumpForce = 10;
    public int Health;
    public int maxHealth = 3;
    

    private Rigidbody rb;
    private Vector3 respawnPoint;
    

    // Start is called before the first frame update
    void Start()
    {
        Health = maxHealth;
        rb = GetComponent<Rigidbody>();
        respawnPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Jump(); 
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
            rb.MovePosition(transform.position + Vector3.right * speed * Time.deltaTime);
            //rotates character facing right
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            // Move left
            rb.MovePosition(transform.position + Vector3.left * speed * Time.deltaTime);
           //rotates character facing left
           transform.rotation = Quaternion.Euler(0f, 180f, 0f);
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
    /// Reduces player's health by 1 and grants temporary invincibility
    /// </summary>

    
    public void LoseHealth()
    {
        // Reduces player's Health


        // Check if lives > 0, take damage if true, else Game Over
        if (Health > 0)
        {
            Health--;
            //causes player to blink when taking damage
            StartCoroutine(Blink());
        }
        else
        {
            print("GAME OVER");
        }
    }





    //makes the player blink in and out 
    public IEnumerator Blink()
    {
        for (int index = 0; index < 30; index++)
        {
            if (index % 2 == 0)
            {
                GetComponent<MeshRenderer>().enabled = false;
            }
            else
            {
                GetComponent<MeshRenderer>().enabled = true;
            }
            yield return new WaitForSeconds(.1f);
        }
        GetComponent<MeshRenderer>().enabled = true;
    }

    /// <summary>
    /// Olivia's Edits
    /// </summary>
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Portal")
        {
            //reset the startPos to the spawnPoint position
            respawnPoint = other.gameObject.GetComponent<Portal>().spawnPoint.transform.position;
            //bring the player back to the start position
            transform.position = respawnPoint;
        }
    }
}
