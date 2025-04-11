using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
/*
 * Xavier Poston
 * Started:4/5/25
 * Last Updated: 4/5/25
 * Handles if the player hits something it will lose a life
 */
=======


/* Joshua Holdenried and Xavier Poston 
* 4/6/25
* Handles the enemies doing damnage to the player
*/

>>>>>>> 0cd5db3dd5bffce385b87d70946ec3184039d2f1
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
