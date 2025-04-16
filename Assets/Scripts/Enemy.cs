using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Cinemachine.CinemachineFreeLook;
using static Cinemachine.DocumentationSortingAttribute;

/* Joshua Holdenried
 * First Updated: 4/8/25
 * Last Updated:  4/8/25
 * This script allows the player to move around the levels
 */
public class Enemy : MonoBehaviour
{
    public int Life = 1;
   

    // Update is called once per frame
    void Update()
    {

        // If the enemy has their life go down to -
        if (Life == 0)
        {
            Destroy(gameObject);
        }


    }
    public void EnemyLoseLife()
    {
        // Reduce's players lives by 1
        Life--;
    }



    }
