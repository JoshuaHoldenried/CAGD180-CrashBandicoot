using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/* Joshua Holdenried and Xavier Poston 
* 4/6/25
* Handles the enemies doing damnage to the player
*/

public class Hazard : MonoBehaviour
{
    //checks for physcial collisisons with the player
    private void OnCollisionEnter(Collision collision)
    {
        //check if the player collided with this hazard
        if (collision.gameObject.GetComponent<PlayerController>())
        {
            collision.gameObject.GetComponent<PlayerController>().LoseLife();
        }
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerController>())
        {
            other.gameObject.GetComponent<PlayerController>().LoseLife();
        }
    }

}
