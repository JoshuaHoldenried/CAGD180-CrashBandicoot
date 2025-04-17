using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
  * Xavier Poston
  * 4/17/25
  * Handles player touching checkpoint and finding its postion
  */
public class Checkpoint : MonoBehaviour
{
      private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController player = other.GetComponent<PlayerController>();
            if (player != null)
            {
                player.UpdateCheckpoint(transform.position);
            }
        }
    }
}
