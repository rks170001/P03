﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ExitLevel();
            
        }
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            ResetLevel();
        }


        void ExitLevel()
        {

            Application.Quit();
        }

        void ResetLevel()
        {
            SceneManager.LoadScene("Scene01");
        }



    }
}
