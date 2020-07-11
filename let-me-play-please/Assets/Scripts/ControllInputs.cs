using System.Collections;
using UnityEngine.Events;
using UnityEngine;

public class ControllInputs : MonoBehaviour
{
    public UnityEvent buttonFunction, EnableButton;
    
    int pressNumber = 0;

    public void PressingButton(){
        buttonFunction.Invoke();
    }

    public void NumberOfPress(int number){
        pressNumber = number;
    }

    public void PushButton(){
        if(pressNumber == 0){
            EnableButton.Invoke();
        }else{
            pressNumber--;
        }
    }
}
