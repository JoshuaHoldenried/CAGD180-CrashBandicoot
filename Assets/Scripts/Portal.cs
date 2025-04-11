using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
<<<<<<< HEAD
 * Xavier Poston
 * Started:4/5/25
 * Last Updated: 4/6/25
=======
 * Joshua Holdenried && Xavier Poston 
 * 4/5/25
>>>>>>> 0cd5db3dd5bffce385b87d70946ec3184039d2f1
 * Handles teleporting players to a new point in the world 
 */
public class Portal : MonoBehaviour
{

    public Transform teleportPoint;

    private void OnTriggerEnter(Collider other)
    {
        //set postition of touched objet to the teleport point 
        other.transform.position = teleportPoint.position;
    }
}
