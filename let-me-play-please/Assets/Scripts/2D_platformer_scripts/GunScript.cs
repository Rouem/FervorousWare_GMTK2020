using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    //references
    [SerializeField] private GameObject bulletPrefab = null;
    [SerializeField] private Transform firePoint = null;
    //state variables
    private bool is_shooting_forward = false;
    private bool is_shooting_up = false;
    //stats constants
    [SerializeField] private float shoot_bpm = 365f;

    private void Start()
    {
        InvokeRepeating("SpawnBulletRate", 0f, 60/shoot_bpm);    
    }

    void Update()
    {
        //inputs
        is_shooting_forward = Input.GetAxis("ShootForward")>=1;
        is_shooting_up = Input.GetAxis("ShootUp")>=1;
        //shoot direction
        if(is_shooting_forward && is_shooting_up)
        {
            transform.localRotation = Quaternion.Euler(0f, 0f, 45f);
        }else if (is_shooting_forward)
        {
            transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
        }else if (is_shooting_up)
        {
            transform.localRotation = Quaternion.Euler(0f, 0f, 90f);
        }
    }

    private void SpawnBulletRate()
    {
        if (is_shooting_up || is_shooting_forward)
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
    }
}
