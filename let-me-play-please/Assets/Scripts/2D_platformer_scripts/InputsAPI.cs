using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputsAPI : MonoBehaviour
{

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

    AnimationsManager anim;
    private void Start() {
		anim = GetComponentInChildren<AnimationsManager>();
	}

    private void Update()
    {
        

        if(!VideoGameController.instance.GetControllState())return;
        
        
        if(VideoGameController.instance.GetRIGHT()){
            right_input = Input.GetAxis("Horizontal_right");
            /* transform.localScale.Set(
                transform.localScale.x,
                transform.localScale.y,
                transform.localScale.z
            ); */
            anim.SetAction(1);
        }
        
        if(VideoGameController.instance.GetLEFT()){
            left_input = Input.GetAxis("Horizontal_left");
            /* transform.localScale.Set(
                transform.localScale.x*-1f,
                transform.localScale.y,
                transform.localScale.z
            ); */
        }

        if(Mathf.Abs(left_input) > 0f || Mathf.Abs(right_input) > 0f)
            anim.SetAction(1);
        else
            anim.SetAction(0);
        
        if(VideoGameController.instance.GetJUMP())
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
    /* public void set_right(bool is_enabled)
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
    } */

    public void set_shoot_up(bool is_enabled)
    {
        is_shooting_up_enabled = is_enabled;
    }

    public void set_shoot_forward(bool is_enabled)
    {
        is_shooting_forward_enabled = is_enabled;
    }
}
