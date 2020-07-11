using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputsAPI : MonoBehaviour
{
    public static InputsAPI instance;
    private void Awake()
    {
        if (InputsAPI.instance != null)
        {
            Destroy(gameObject);
        }
        instance = this;
    }

    //walk
    private float right_input = 0f;
    private float left_input = 0f;
    //--bools
    private bool right_input_enabled = true;
    private bool left_input_enabled = true;

    //jump
    private bool is_jumping = false;
    //--bool
    private bool is_jumping_enabled = true;

    //shoot
    private bool is_shooting_forward = false;
    private bool is_shooting_up = false;
    //--bools
    private bool is_shooting_forward_enabled = true;
    private bool is_shooting_up_enabled = true;

    

    private void Update()
    {
        if(right_input_enabled)
            right_input = Input.GetAxis("Horizontal_right");
        
        if(left_input_enabled)
            left_input = Input.GetAxis("Horizontal_left");
        
        if(is_jumping_enabled)
            is_jumping = Input.GetAxis("Jump")>=1;
        
        if(is_shooting_forward_enabled)
            is_shooting_forward = Input.GetAxis("ShootForward") >= 1;
        
        if(is_shooting_up_enabled)
            is_shooting_up = Input.GetAxis("ShootUp") >= 1;
    }

    //PerformAPI
    public float WalkDirection()
    {
        return right_input + left_input;
    }

    public bool IsJumping()
    {
        return is_jumping;
    }

    public bool IsShootingUp()
    {
        return is_shooting_up;
    }

    public bool IsShootingForward()
    {
        return is_shooting_forward;
    }

    //ENABLER/DISABLE API
    public void set_right(bool is_enabled)
    {
        right_input_enabled = is_enabled;
    }

    public void set_left(bool is_enabled)
    {
        left_input_enabled = is_enabled;
    }

    public void set_jump(bool is_enabled)
    {
        is_jumping_enabled = is_enabled;
    }

    public void set_shoot_up(bool is_enabled)
    {
        is_shooting_up_enabled = is_enabled;
    }

    public void set_shoot_forward(bool is_enabled)
    {
        is_shooting_forward_enabled = is_enabled;
    }
}
