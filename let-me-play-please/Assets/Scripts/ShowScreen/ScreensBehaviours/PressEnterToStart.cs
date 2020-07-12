using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressEnterToStart : MonoBehaviour
{
    public Action enter_start_event;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            enter_start_event();
        }
    }
}
