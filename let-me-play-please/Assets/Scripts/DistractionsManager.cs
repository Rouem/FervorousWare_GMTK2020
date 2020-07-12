using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistractionsManager : MonoBehaviour
{
    #region Singleton
    public static DistractionsManager instance;
    private void Awake() {
        if(DistractionsManager.instance != null)
            Destroy(gameObject);
        instance = this;
    }
    #endregion    
    

    #region Problem
    private bool problemSolved = true;
    public void SolveProblem(){
        problemSolved = true;
    }
    public bool ProblemState(){
        return problemSolved;
    }
    #endregion

    public float count, maxTime = 35f;
    public GameObject cablePuzzle;
    // Start is called before the first frame update
    void Start()
    {
        problemSolved = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(!problemSolved) return;

        if(count >= maxTime){
            int sortProblem = (int)Random.Range(1f,3f);
            Debug.Log("Distraction: "+sortProblem);
            if(sortProblem.Equals(1)){
                VideoGameController.instance.SortDefectButton();
            }
            if(sortProblem.Equals(2)){
                cablePuzzle.SetActive(true);
                VideoGameController.instance.CrashControll();
                HandsManager.instance.hands.SetActive(false);
                HandsManager.instance.handsOnCable.SetActive(true);
            }

            maxTime = Random.Range(05f,20f);
            count = 0;
            problemSolved = false;
        }else
            count += Time.deltaTime;
    }
}
