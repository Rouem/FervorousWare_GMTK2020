using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenMannager : MonoBehaviour
{
    //references
    [SerializeField] ShowScreen start_screen = null;
    [SerializeField] ShowScreen loose_screen = null;
    [SerializeField] ShowScreen win_screen = null;

    //variables
    private ShowScreen active_screen = null;

    private void Start()
    {
        ShowStartScreen();
    }

    public void ShowStartScreen()
    {
        active_screen?.HideTheScreen();
        start_screen?.ShowTheScreen();
        active_screen = start_screen;
    }

    public void ShowLooseScreen()
    {
        active_screen?.HideTheScreen();
        loose_screen?.ShowTheScreen();
        active_screen = loose_screen;
    }

    public void ShowWinScreen()
    {
        active_screen?.HideTheScreen();
        win_screen?.ShowTheScreen();
        active_screen = win_screen;
    }
}

