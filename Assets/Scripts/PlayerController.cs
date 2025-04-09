using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


/* Joshua Holdenried && Xavier Poston 
 * First Updated: 4/6/25
 * Last Updated:  4/6/25
 * This script allows the player to move around the levels
 */
public class PlayerController : MonoBehaviour
{
    public GameObject crashBandicoot;
    public Color newColor;
    public Color trueColor;
    public float speed = 5f;
    public int lives;
    public float JumpForce = 10;
    public float killHeight = -5;
    private Rigidbody rigidbody;
    private Vector3 respawnPoint;
    public bool attacking;

    private PlayerLivesManager livesManager;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();

        livesManager = FindObjectOfType<PlayerLivesManager>();

        respawnPoint = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < killHeight)
            LoseLife();
        
    }
    void FixedUpdate()
    {
        Move(); 
        Jump();
        Attack();
    }
    private void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rigidbody.MovePosition(transform.position + (Vector3.forward * speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.A))
        {
            rigidbody.MovePosition(transform.position + (Vector3.left * speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.D))
        {
            rigidbody.MovePosition(transform.position + (Vector3.right * speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.S))
        {
            rigidbody.MovePosition(transform.position + (Vector3.back * speed * Time.deltaTime));
        }
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && OnGround())
        {
            print("Jumped");
            rigidbody.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        }
    }




    public void Attack()
    {
        if (Input.GetKey(KeyCode.E))
        {
            print("Attack");
            attacking = true;
            StopAttack();
            attacking = false;
        }
         }

    private IEnumerator StopAttack()
    {
        // Start the timer to wait
        print("Timer Started");
        yield return new WaitForSeconds(3);
        print("Timer Ended");

    }
   
    private bool OnGround()
    {
        bool onGround = false;

        RaycastHit hit;

        if (Physics.Raycast(transform.position, Vector3.down, out hit, 1.2f))
        {
            onGround = true;
        }

        return onGround;
    }



    public void LoseLife()
    {
        // Reduce's players lives by 1
        lives--;

        if (livesManager != null)
        {
            livesManager.LoseLife(); // Updates UI
        }
        // Check if lives > 0 
        if (lives > 0)
        {
            // Respawn - Sets the player's position, to the position of the respawn point
            transform.position = respawnPoint;
        }
        else
        {
            // Game Over
            print("Game Over");
            SceneManager.LoadScene(1);
        }

    }

}

