using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WumpaFruitManger : MonoBehaviour
{
    // Start is called before the first frame update
    public WumpaFruit WumpaFruit;
    public int wumpaFruit = 0;
    public TextMeshProUGUI WumpaFruitText;
    public int wumpaFruitCount = 0;
    public int playerLives = 3; // Or however many you start with


    public TextMeshProUGUI wumpaFruitText;
    public TextMeshProUGUI livesText;





    public void AddWumpaFruit(int amount)
    {
        wumpaFruitCount += amount;

        // Check for extra life
        if (wumpaFruitCount >= 100)
        {
            playerLives += 1;
            wumpaFruitCount -= 100; // Keeps leftover fruit if over 100
        }

        UpdateUI();
    }

    void UpdateUI()
    {
        if (wumpaFruitText != null)
            wumpaFruitText.text = "Wumpa: " + wumpaFruitCount;

        if (livesText != null)
            livesText.text = "Lives: " + playerLives;
    }
}
    
