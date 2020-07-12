using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandsManager : MonoBehaviour
{

    public static HandsManager instance;
    private void Awake() {
        if(HandsManager.instance != null)
            Destroy(gameObject);
        instance = this;
    }
    public Sprite up,down,left,right,fire,jump;

    public SpriteRenderer leftHand, rightHand;
    public GameObject hands, handsOnCable;
    

    // Update is called once per frame
    void Update()
    {

        if(DistractionsManager.instance.ProblemState()){
            HandsAnimation();
        }

    }

    void HandsAnimation(){
        if(Input.GetKeyDown(KeyCode.A))
            leftHand.sprite = left;
        
        if(Input.GetKeyDown(KeyCode.D))
            leftHand.sprite = right;
        
        if(Input.GetKeyDown(KeyCode.W))
            leftHand.sprite = up;
        
        if(Input.GetKeyDown(KeyCode.S))
            leftHand.sprite = down;
        
        if(Input.GetKeyDown(KeyCode.J))
            rightHand.sprite = fire;
        
        if(Input.GetKeyDown(KeyCode.K))
            rightHand.sprite = jump;
    }

    



}
