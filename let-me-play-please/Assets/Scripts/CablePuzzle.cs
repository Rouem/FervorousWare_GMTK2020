using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CablePuzzle : MonoBehaviour
{
    public Transform currentPoint, reconnectPoint;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPos = currentPoint.position;
        currentPoint.position = SetLimits(currentPos);
        
    }

    Vector3 SetLimits(Vector3 pos){
        pos.x += Input.GetAxis("Mouse X") * Time.deltaTime;
        pos.y += Input.GetAxis("Mouse Y") * Time.deltaTime;
        if(pos.x <= 1.85f)
            pos.x = 1.85f;
        if(pos.x >= 3.48f)
            pos.x = 3.48f;
        if(pos.y <= 1.15f)
            pos.y = 1.15f;
        if(pos.y >= 2.8f)
            pos.y = 2.8f;
        return pos;
    }
}
