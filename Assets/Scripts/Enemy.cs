using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Joshua Holdenried && Xavier Poston 
 * First Updated: 4/8/25
 * Last Updated:  4/8/25
 * This script allows the player to move around the levels
 */
public class Enemy : MonoBehaviour
{
    public int Life = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      

    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerController>())
        {
            Life--;
        }
        if (Life == 0)
            Destroy(gameObject);
    }

}
