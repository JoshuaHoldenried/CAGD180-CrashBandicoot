using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


/* Joshua Holdenried & Xavier Poston
 * First Updated: 4/6/25
 * Last Updated:  4/17/25
 * This script allows the player to move around the levels
 */
public class PlayerController : MonoBehaviour
{
    public GameObject crashBandicoot;
    public Color newColor;
    public Color trueColor;
    public float speed = 5f;
    public float jumpRayCast;
    public int lives;
    public float JumpForce = 10;
    public float killHeight = -5;
    private Rigidbody rigidbody;
    private Vector3 respawnPoint;
    public bool attacking = false;

    public PlayerLivesManager livesManager;




/* 
    Put a bool
    Check for collision
    After collision check for the bool (Player is or is not attacking)
    If the bool is true - kill the enemy
    If the bool is false - kill the player'
*/

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

        if (attacking == false)
        { // Check the boolean value
            print("Attacking is False");
        }
        else
        {
            print("Attacking is True");
        }

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
            rigidbody.velocity = Vector3.zero;
            rigidbody.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        }
    }




    public void Attack()
    {
        if (Input.GetKey(KeyCode.E))
        {
            gameObject.GetComponent<Renderer>().material.color = newColor;
            attacking = true;
            print("Attack");
            StartCoroutine(StopAttack());
        }
    }

    private IEnumerator StopAttack()
    {
        // Start the timer to wait
        print("Timer Started");
        yield return new WaitForSeconds(3);
        print("Timer Ended");
        print("Attack Stopped");
        attacking = false;
        gameObject.GetComponent<Renderer>().material.color = trueColor;        
    }

    private bool OnGround()
    {
        bool onGround = false;

        RaycastHit hit;

        if (Physics.Raycast(transform.position, Vector3.down, out hit, jumpRayCast))
        {
            onGround = true;
        }

        return onGround;
    }



    public void LoseLife()
    {
        // Reduce's players lives by 1
        lives--;
        livesManager.LoseLife();

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
            SceneManager.LoadScene(2);
        }

    }

    public void UpdateCheckpoint(Vector3 newCheckpoint)
    {
        respawnPoint = newCheckpoint;
    }




    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<Enemy>())
        {

            print("Player Attacked The Enemy");
            if (attacking == true)
            {
                other.gameObject.GetComponent<Enemy>().EnemyLoseLife();
            }
            else if (attacking == false)
            {
                print("Enemy Attacked Player");
                LoseLife();
            }

        }

    }

   
}

