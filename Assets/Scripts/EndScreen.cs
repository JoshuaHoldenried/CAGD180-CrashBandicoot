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
            print("Quit Game");
            Application.Quit();
        }

        public void MainMenu(int sceneIndex)
        {
           SceneManager.LoadScene(1);
        }
        public void TryAgain(int sceneIndex)
        {
        SceneManager.LoadScene(0);
        }
        public void Play(int sceneIndex)
        {
        SceneManager.LoadScene(0);
        }

}

