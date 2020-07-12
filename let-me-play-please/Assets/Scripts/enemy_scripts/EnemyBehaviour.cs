using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    //references
    [SerializeField] private GameObject bulletPrefab = null;
    [SerializeField] private Transform spawnBulletPoint = null;
    private Rigidbody2D controller;

    //properties
    private float shoot_bpm = 100;
    private bool is_shooting = false;
    private bool is_walking = false;

    private void Start()
    {
        controller = GetComponent<Rigidbody2D>();
        InvokeRepeating("SpawnBulletRate", 0f, 60 / shoot_bpm);
    }

    private void SpawnBulletRate()
    {
        if (is_shooting)
        {
            Instantiate(bulletPrefab, spawnBulletPoint.position, spawnBulletPoint.rotation);
        }
    }

    public void BeAgressive()
    {
        transform.Rotate(0f, 180f, 0f);//look to player
        is_shooting = true;
        is_walking = true;
    }

    private void FixedUpdate()
    {
        //platformer movement made with Move() method at controller
        if (is_walking)
        {
            float horizontal_movement = -1 * Time.fixedDeltaTime;
            var new_position = transform.position;
            new_position.x = new_position.x + horizontal_movement;
            transform.position = new_position;
        }
            
    }

}
