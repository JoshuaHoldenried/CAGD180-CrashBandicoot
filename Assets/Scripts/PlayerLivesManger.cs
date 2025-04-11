using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


/*
<<<<<<< HEAD
* Xavier Poston
* Started:4/6/25
* Last Updated: 4/8/25
* Handles Ui for lifes
=======
* Joshua Holdenried && Xavier Poston 
* 4/6/25
* Handles ui and lives
>>>>>>> 0cd5db3dd5bffce385b87d70946ec3184039d2f1
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

        private void UpdateLivesUI()
        {
        gameObject.GetComponent<PlayerController>().LoseLife();

        if (livesText != null)
            {
                livesText.text = "Lives: " + lives;
            }
        }

}
