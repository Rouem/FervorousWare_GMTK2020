using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoGameController : MonoBehaviour
{
    
    bool up,down,left,right,fire,jump;
    public Camera cam;

    #region INPUTS
    public bool GetUP(){
        return up;
    }
    
    public bool GetDOWN(){
        return down;
    }

    public bool GetLEFT(){
        return left;
    }

    public bool GetRIGHT(){
        return right;
    }

    public bool GetFIRE(){
        return fire;
    }

    public bool GetJUMP(){
        return jump;
    }

    
    public void SetUP(bool state){
        up = state;
    }
    
    public void SetDOWN(bool state){
        down = state;
    }
    
    public void SetLEFT(bool state){
        left = state;
    }

    public void SetRIGHT(bool state){
        right = state;
    }

    public void SetFIRE(bool state){
        fire = state;
    }

    public void SetJUMP(bool state){
        jump = state;
    }
    #endregion

    public ControllInputs[] buttons;
    
    private void Update() {
        if(Input.GetMouseButtonDown(0)){
    	   	Ray ray = cam.ScreenPointToRay(Input.mousePosition);
    	   	RaycastHit hit;
    	   	
    	   	if(Physics.Raycast(ray, out hit, 100)){
				if(hit.transform.GetComponent<ControllInputs>() != null){
    	   			hit.transform.GetComponent<ControllInputs>().PressingButton();
				}
    	   	}
        }
    }

    int lastSorted = -1;
    public void SortDefectButton(){
        int sort = Random.Range(0,buttons.Length);
        if(sort.Equals(lastSorted)){
            if(sort.Equals(lastSorted))
                sort++;
            if(sort > buttons.Length-1)
                sort = 0;
            else
                sort++;
        }
        Debug.Log(sort+" Button: "+buttons[sort].name);
        lastSorted = sort;
    }

}
