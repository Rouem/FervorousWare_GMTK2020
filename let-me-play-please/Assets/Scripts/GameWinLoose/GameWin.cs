using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWin : MonoBehaviour
{
    public Action game_win_event;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        game_win_event();
    }
}
