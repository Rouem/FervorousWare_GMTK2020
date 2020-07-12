﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLoop : MonoBehaviour
{
    //references
    [SerializeField] ScreenMannager screens = null;
    [SerializeField] CharacterLife character = null;

    private void Start()
    {
        character.die_event += LooseGame;
    }
    //Win condition (reaches the end)
    //--ty for playing

    //Loose condition (dies)
    private void LooseGame()
    {
        screens?.ShowLooseScreen();
    }

    private void RestartEverything()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    //--restart?
    //--reload scene 

}
