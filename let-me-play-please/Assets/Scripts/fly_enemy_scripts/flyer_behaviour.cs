using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyer_behaviour : MonoBehaviour
{
    private bool is_walking = false;
    [SerializeField] private float fly_speed = 1;

    public void BeAgressive()
    {
        is_walking = true;
        GetComponent<AudioSource>().Play();
        Destroy(gameObject, 3);
    }

    private void FixedUpdate()
    {
        //platformer movement made with Move() method at controller
        if (is_walking)
        {
            float horizontal_movement = -fly_speed * Time.fixedDeltaTime;
            var new_position = transform.position;
            new_position.x = new_position.x + horizontal_movement;
            transform.position = new_position;
        }

    }
}
