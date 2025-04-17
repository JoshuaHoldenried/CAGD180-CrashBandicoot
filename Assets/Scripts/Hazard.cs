using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/* Joshua Holdenried
* First Updated: 4/6/25
* Last Updated: 4/15/25
* Handles the enemies doing damnage to the player
*/

public class Hazard : MonoBehaviour
{
    // Checks if the player collided with a hazardous enemy
    private void OnCollisionEnter(Collision collision)
    {
        //check if the player collided with this hazard
        if (collision.gameObject.GetComponent<PlayerController>())
        {
            collision.gameObject.GetComponent<PlayerController>().LoseLife();
        }
    }

    // Checks if the player collided with a hazardous object
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerController>())
        {
            other.gameObject.GetComponent<PlayerController>().LoseLife();
        }
    }

}
