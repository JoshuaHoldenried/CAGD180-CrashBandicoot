using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


/*
* Xavier Poston
* Started:4/6/25
* Last Updated: 4/17/25
* Handles Ui for lifes
*/
public class PlayerLivesManager : MonoBehaviour
{
    public int lives = 3;
    public TextMeshProUGUI livesText;

    private void Start()
    {
        UpdateLivesUI(); // Ensure UI updates at game start
    }

    public void LoseLife()
    {
        if (lives > 0)
        {
            lives--;
            UpdateLivesUI(); // Update UI whenever lives decrease
        }
    }
    public void AddLife()
    {
        lives++;
        UpdateLivesUI();
    }

    private void UpdateLivesUI()
    {
        if (livesText != null)
        {
            livesText.text = "Lives: " + lives;
        }
    }
}

