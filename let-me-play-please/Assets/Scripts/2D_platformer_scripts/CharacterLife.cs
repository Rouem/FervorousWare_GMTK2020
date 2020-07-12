using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterLife : MonoBehaviour
{
    //references
    [SerializeField] private float life = 4f;
    [SerializeField] private Text lifeText = null;

    //events
    public Action die_event;
    public GameObject effect;

    private void Start()
    {
        if (lifeText)
            lifeText.text = life.ToString();
    }

    public void TakeDamage(float damage)
    {
        life -= damage;
        if (lifeText)
            lifeText.text = life.ToString();
        if (life <= 0)
            GameOver();
    }

    private void GameOver()
    {
        if(!effect.Equals(null)){
            Instantiate(effect,transform.position,Quaternion.identity);
            effect = null;
        }
        Debug.Log("Voce morreu :(");
        die_event();
        gameObject.SetActive(false);
    }
}
