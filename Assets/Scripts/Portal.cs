using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
<<<<<<< HEAD
 * Xavier Poston && Joshua Holdenried
 * Started:4/5/25
 * Last Updated: 4/6/25
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
