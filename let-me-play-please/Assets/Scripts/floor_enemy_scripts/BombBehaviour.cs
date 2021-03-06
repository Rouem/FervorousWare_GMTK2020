﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombBehaviour : MonoBehaviour
{
    //properties
    [SerializeField] private float bomb_velocity = 2;
    [SerializeField] private float bomb_damage = 3f;

    //status
    private bool is_released = false;
    public void ReleaseBomb()
    {
        if(!is_released)
        GetComponent<AudioSource>().Play();
        is_released = true;
    }

    private void FixedUpdate()
    {
        if (is_released)
        {
            float vertical_movement = -bomb_velocity * Time.fixedDeltaTime;
            var new_position = transform.position;
            new_position.y = new_position.y + vertical_movement;
            transform.position = new_position;
        }
    }
    public GameObject effect;
    public LayerMask floor;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer.Equals(floor.value)){
            Instantiate(effect,transform.position,Quaternion.identity);
            Destroy(gameObject);
        }
        
        CharacterLife mainChar = collision.GetComponent<CharacterLife>();
        mainChar?.TakeDamage(bomb_damage);
        Destroy(GetComponent<SpriteRenderer>());
    }
}
