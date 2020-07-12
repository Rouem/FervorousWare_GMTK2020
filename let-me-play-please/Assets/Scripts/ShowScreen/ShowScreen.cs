using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowScreen : MonoBehaviour
{
    public void HideTheScreen()
    {
        gameObject.SetActive(false);
    }

    public void ShowTheScreen()
    {
        gameObject.SetActive(true);
    }
}
