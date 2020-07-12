using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLoop : MonoBehaviour
{
    //references
    [SerializeField] ScreenMannager screens = null;
    [SerializeField] CharacterLife character = null;
    [SerializeField] PressEnterToTryAgain try_again = null;
    [SerializeField] PressEnterToStart enter_start = null;
    [SerializeField] GameWin game_win = null;

    private void Start()
    {
        Time.timeScale = 0;
        character.die_event += LooseGame;
        try_again.try_again_event += RestartEverything;
        enter_start.enter_start_event += StartGame;
        game_win.game_win_event += CongratsGameWon;
    }

    private void StartGame()
    {
        screens.HideAll();
        Time.timeScale = 1;
    }

    //Loose condition (dies)
    private void LooseGame()
    {
        screens?.ShowLooseScreen();
        Time.timeScale = 0;
    }
    //restarting when press enter
    private void RestartEverything()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    } 

    private void CongratsGameWon()
    {
        screens?.ShowWinScreen();
        Time.timeScale = 0;
    }

}
