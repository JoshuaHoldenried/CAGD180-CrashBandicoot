using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Xavier Poston
 * Started:4/10/25
 * Last Updated: 4/10/25
 * Handles disapering platforms
 */
public class TimedPlatform : MonoBehaviour
{
    public float timeBeforeFall;      // X seconds before turning off
    public float respawnTime;         // X seconds before turning back on

    private Collider platformCollider;
    

    private void Start()
    {
        platformCollider = GetComponent<Collider>();
      
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Only trigger when player lands on it
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(PlatformRoutine());
        }
    }

    private IEnumerator PlatformRoutine()
    {
        yield return new WaitForSeconds(timeBeforeFall);

        // Disable platform
        platformCollider.enabled = false;
        

        yield return new WaitForSeconds(respawnTime);

        // Re-enable platform
        platformCollider.enabled = true;
       
    }
}

