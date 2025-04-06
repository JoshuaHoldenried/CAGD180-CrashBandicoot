using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

/* Joshua Holdenried
 * First Updated: 4/6/25
 * Last Updated:  4/6/25
 * This script allows the player to move around the levels
 */
public class PlayerController : MonoBehaviour
{

    public float speed = 5f;
    public int lives = 3;
    public float JumpForce = 10;
    public float killHeight = -5;
    private Rigidbody rigidbody;
    private Vector3 respawnPoint;


    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();

        respawnPoint = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        Move();

        if (transform.position.y < killHeight)
            LoseLife();
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

    public void LoseLife()
    {
        // Reduce's players lives by 1
        lives--;
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

