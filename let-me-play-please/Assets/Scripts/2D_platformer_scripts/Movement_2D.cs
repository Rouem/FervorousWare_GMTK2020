using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// This script carries the 2D-platformer inputs
/// </summary>
//movement physics component
[RequireComponent(typeof(PlatformPhysics))]
public class Movement_2D : MonoBehaviour
{
    //cached variables
    private PlatformPhysics controller;
    //state variables
    private float walk_direction = 0;
    //attributes
    private float walk_speed = 60f;
    private bool is_jumping = false;

    private void Start()
    {
        controller = GetComponent<PlatformPhysics>();
    }

    private void Update()
    {
        walk_direction = Input.GetAxis("Horizontal");
        is_jumping = Input.GetAxis("Jump") >= 1;
       
    }

    private void FixedUpdate()
    {
        //platformer movement made with Move() method at controller
        var horizontal_movement = walk_direction * walk_speed * Time.fixedDeltaTime;
        controller.Move(horizontal_movement, false, is_jumping);
    }
}
