using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot_2D : MonoBehaviour
{
    //references
    [SerializeField] private GameObject bulletPrefab = null;
    [SerializeField] private Transform firePoint = null;
    //state variables
    private bool is_shooting_forward = false;
    private bool is_shooting_up = false;

    // Update is called once per frame
    void Update()
    {
        //inputs
        is_shooting_forward = Input.GetAxis("ShootForward")>=1;
        is_shooting_up = Input.GetAxis("ShootUp")>=1;
    }

    private void FixedUpdate()
    {
        if (is_shooting_up || is_shooting_forward)
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
    }
}
