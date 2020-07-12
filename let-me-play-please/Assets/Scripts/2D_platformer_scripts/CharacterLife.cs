using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLife : MonoBehaviour
{
    [SerializeField] private float life = 4f;
    public void TakeDamage(float damage)
    {
        life -= damage;
        Debug.Log(life);
        if (life <= 0)
            GameOver();
    }

    private void GameOver()
    {
        Debug.Log("Voce morreu :(");
        gameObject.SetActive(false);
    }
}
