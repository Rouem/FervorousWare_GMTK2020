using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraFollowCharacter : MonoBehaviour
{
    [SerializeField] private GameObject characterReference = null;

    void Update()
    {
        float x_position = characterReference.transform.position.x; //-3 is the default character position
        Vector3 new_position = gameObject.transform.position;
        new_position.x = x_position;
        gameObject.transform.position = new_position; 
    }
}
