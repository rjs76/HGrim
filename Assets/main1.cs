﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main1 : MonoBehaviour {

    public void Spanish()
         {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

         }
    public void Playgame()
         {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

         }
   


        public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}

