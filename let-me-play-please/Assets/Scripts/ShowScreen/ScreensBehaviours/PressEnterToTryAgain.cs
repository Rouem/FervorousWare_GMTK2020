using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressEnterToTryAgain : MonoBehaviour
{
    public Action try_again_event; 
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            try_again_event();
        }
    }
}
