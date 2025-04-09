using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WumpaFruitManger : MonoBehaviour
{
    // Start is called before the first frame update
    public WumpaFruit WumpaFruit;
    public int wumpaFruit  = 0;
    public TextMeshProUGUI WumpaFruitText;


    public void AddWumpaFruit(int amount)
    {
        wumpaFruit += amount;
        UpdateWumpaFruitUI();
    }

    void UpdateWumpaFruitUI()
    {
        GetComponent<WumpaFruitManger>().WumpaFruitText.text = "WumpaFruits: " + wumpaFruit++;
    }
}
