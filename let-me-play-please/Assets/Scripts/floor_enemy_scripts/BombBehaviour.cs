using System.Collections;
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
        is_released = true;
        GetComponent<AudioSource>().Play();
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

    //explosion effect
    private void OnTriggerEnter2D(Collider2D collision)
    {
        CharacterLife mainChar = collision.GetComponent<CharacterLife>();
        mainChar?.TakeDamage(bomb_damage);
        Destroy(gameObject);
    }
}
