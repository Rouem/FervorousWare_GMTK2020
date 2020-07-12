using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyer_agro : MonoBehaviour
{
    [SerializeField] private flyer_behaviour flyer = null;

    private bool is_agressive = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!is_agressive)
        {
            flyer.BeAgressive();
            is_agressive = true;
        }
    }
}
