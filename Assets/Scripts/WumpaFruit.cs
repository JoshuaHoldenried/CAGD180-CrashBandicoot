using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;



/*
*Xavier Poston
* 4/6/25
* Handles the player collecting the wumpa fruit, and tracking the wumpa fruit in the UI
*/


public class WumpaFruit : MonoBehaviour
{
    // Value of the WumpaFruit
    public int WumpaFruitValue = 1;
    public int wumpaFruit = 0;


    // Update is called once per frame
    void Update()
    {
        //rotate the WumpaFruit each frame 
        transform.Rotate(0, 4, 0);

    }

    private void OnTriggerEnter(Collider other)
    {
        //check if touched object was the player
        if (other.GetComponent<PlayerController>())
        {

            WumpaFruitManger WumpaFruitManager = FindObjectOfType<WumpaFruitManger>();
            if (WumpaFruitManager != null)
            {
                WumpaFruitManager.AddWumpaFruit(WumpaFruitValue); // Update WumpaFruit in the WumpaFruitManger
            }

            //removed the WumpaFruit 
            Destroy(gameObject);

        }
    }


    public void AddWumpaFruit(int amount)
    {
        wumpaFruit += amount;
        WumpaFruitUI();
    }

    public void WumpaFruitUI()
    {
        GetComponent<WumpaFruitManger>().wumpaFruitText.text = "WumpaFruit: " + wumpaFruit++;


    }

}
