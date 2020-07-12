using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationsManager : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void SetAction(int action){
        anim.SetInteger("action",action);
    }
    public void SetAction(string action){
        anim.SetTrigger(action);
    }
    public void SetAction(string booleanName, bool value){
        anim.SetBool(booleanName,value);
    }
}
