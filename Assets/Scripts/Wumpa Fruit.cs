using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
/*
 * Xavier Poston
 * Started:4/8/25
 * Last Updated: 4/17/25
 * Handles Ui for wampa fruit and plus 1 life for 100 wumpas 
 */
public class WumpaFruitManger : MonoBehaviour
{
    public int wumpaFruitCount = 0;
    public TextMeshProUGUI wumpaFruitText;
    public PlayerLivesManager playerLivesManager; 
    public void AddWumpaFruit(int amount)
    {
        wumpaFruitCount += amount;

        // Check for extra life; add extra life to the manager if needed.
        if (wumpaFruitCount >= 100)
        {
            // Earn an extra life through the manager.
            playerLivesManager.AddLife();
            wumpaFruitCount -= 100; // Keep leftover fruit if over 100
        }

        UpdateUI();
    }

    void UpdateUI()
    {
        if (wumpaFruitText != null)
            wumpaFruitText.text = "Wumpa: " + wumpaFruitCount;
    }
}
    
