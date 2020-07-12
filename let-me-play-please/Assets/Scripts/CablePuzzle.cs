using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CablePuzzle : MonoBehaviour
{
    public Transform currentPoint, reconnectPoint;
    [Header("Corners")]
    public Transform top;
    public Transform left,right,bottom;
    float radius;
    void Start()
    {
        radius = reconnectPoint.localScale.x;
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    float count = 0;
    void Update()
    {

        if(VideoGameController.instance.GetControllState())
        return;

        Vector3 currentPos = currentPoint.position;
        currentPoint.position = SetLimits(currentPos);

        if(Vector3.Distance(currentPoint.position,reconnectPoint.position) <= 0.3f){
            Debug.Log("Reconnected!");
            if(count >= 0.4f){
                count = 0;
                VideoGameController.instance.ReconectControll();
                NewReconnectionPoint();
                gameObject.SetActive(false);
            }else
                count += Time.deltaTime;
        }else
            Debug.Log("Disconnected!");
        
    }

    Vector3 SetLimits(Vector3 pos){
        pos.x += Input.GetAxis("Mouse X") * Time.deltaTime;
        pos.y += Input.GetAxis("Mouse Y") * Time.deltaTime;
        if(pos.x <= left.position.x)
            pos.x = left.position.x;
        if(pos.x >= right.position.x)
            pos.x = right.position.x;
        if(pos.y <= bottom.position.y)
            pos.y = bottom.position.y;
        if(pos.y >= top.position.y)
            pos.y = top.position.y;
        return pos;
    }

    public void NewReconnectionPoint(){
        Vector3 pos = new Vector3();
        pos.x = Random.Range(left.position.x,right.position.x);
        pos.y = Random.Range(bottom.position.y,top.position.y);
        pos.z = reconnectPoint.position.z;
        reconnectPoint.position = pos;
    }

}
