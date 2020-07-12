using System.Collections;
using UnityEngine.Events;
using UnityEngine;

public class ControllInputs : MonoBehaviour
{
    public UnityEvent buttonFunction, EnableButton;
    
    public GameObject deffect;
    private void Start() {
        deffect = transform.Find("deffect").gameObject;
    }
    int pressNumber = 0;

    public void PressingButton(){
        deffect.SetActive(true);
        buttonFunction.Invoke();
        deffect = transform.Find("deffect").gameObject;
    }

    public void NumberOfPress(int number){
        pressNumber = number;
    }

    public void PushButton(){
        if(pressNumber == 0){
            Debug.Log("Button '"+gameObject.name+" is work again!");
            EnableButton.Invoke();
            DistractionsManager.instance.SolveProblem();
            deffect.SetActive(false);
        }else{
            Debug.Log("Button '"+gameObject.name+" is pushed. Remain: "+pressNumber);
            pressNumber--;
        }
    }
}
