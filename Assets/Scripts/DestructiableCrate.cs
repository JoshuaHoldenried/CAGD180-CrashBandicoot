using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructiableCrate : MonoBehaviour
{
    public int wumpaDropAmount; // Editable in inspector
    public GameObject wumpaFruitPrefab; // Assign your Wumpa prefab here


    private void OnCollisionEnter(Collision collision)
    {
        PlayerController player = collision.gameObject.GetComponent<PlayerController>();
        if (player != null)
        {
                bool isJumpAttack = player.transform.position.y > transform.position.y + 0.5f;

                if (isJumpAttack) //|| player.attacking)
                {
                    DestroyCrate();
                }
            
        }
    }

    private void DestroyCrate()
    {
        int spawnCount = wumpaDropAmount;

        //  max drop limit of 5
        if (spawnCount > 5)
        {
            spawnCount = 5;
        }

        Vector3 spawnPos = transform.position;

        for (int i = 0; i < spawnCount; i++)
        {
            Instantiate(wumpaFruitPrefab, spawnPos, Quaternion.identity);
        }

        Destroy(gameObject); // Remove the crate
    }
}
