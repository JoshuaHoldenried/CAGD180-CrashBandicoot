using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
    /*
  * Xavier Poston
  * 4/17/25
  * Handles end and main menu
  */
    public class EndScreen : MonoBehaviour
    {
        public void QuitGame()
        {
            Application.Quit();
        }

        public void SwitchScene(int sceneIndex)
        {
           SceneManager.LoadScene(3);
    }
    }

