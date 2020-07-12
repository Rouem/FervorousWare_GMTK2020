using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoGameController : MonoBehaviour
{
    #region Singleton
        public static VideoGameController instance;
        private void Awake() {
            if(VideoGameController.instance != null)
                Destroy(gameObject);
            instance = this;
        }
    #endregion
    
    bool[] activedButton = new bool[6];
    bool controllState = true;
    public Camera cam;


    #region INPUTS
    public bool GetLEFT(){
        return activedButton[0];
    }
    
    public bool GetRIGHT(){
        return activedButton[1];
    }

    public bool GetFIRE(){
        return activedButton[2];
    }

    public bool GetJUMP(){
        return activedButton[3];
    }

    
    public void SetLEFT(bool state){
        activedButton[0] = state;
    }
    
    public void SetRIGHT(bool state){
        activedButton[1] = state;
    }
    
    public void SetFIRE(bool state){
        activedButton[2] = state;
    }

    public void SetJUMP(bool state){
        activedButton[3] = state;
    }
    #endregion

    public ControllInputs[] buttons;
    
    public void ReloadGame(){
        Start();
    }

    void Start() {
        ReconectControll();
        for(int i = 0; i < activedButton.Length;i++)
            activedButton[i] = true;
    }
  
    private void Update() {
        if(Input.GetMouseButtonDown(0)){
    	   	Ray ray = cam.ScreenPointToRay(Input.mousePosition);
    	   	RaycastHit hit;
    	   	
    	   	if(Physics.Raycast(ray, out hit, 1000)){
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
        int numberOfPress = Random.Range(2,9);
        Debug.Log("Button "+buttons[sort].name+" isn't working!");
        buttons[sort].NumberOfPress(numberOfPress);
        buttons[sort].deffect.SetActive(true);
        activedButton[sort] = false;
        lastSorted = sort;
    }

    public bool GetControllState(){
        return controllState;
    }

    public void CrashControll(){
        controllState = false;
    }

    public void ReconectControll(){
        controllState = true;
        HandsManager.instance.hands.SetActive(true);
        HandsManager.instance.handsOnCable.SetActive(false);
        DistractionsManager.instance.SolveProblem();
    }

}
