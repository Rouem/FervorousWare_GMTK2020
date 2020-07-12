using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAgro : MonoBehaviour
{
    //reference
    [SerializeField] EnemyBehaviour enemy = null;
    private bool is_agressive;

    //when player enters the agro area
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!is_agressive)
        {
            enemy.BeAgressive();
            is_agressive = true;
        }
    }
}
