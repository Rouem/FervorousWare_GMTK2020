using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    //references
    [SerializeField] private GameObject bulletPrefab = null;
    [SerializeField] private Transform spawnBulletPoint = null;

    //properties
    private float shoot_bpm = 200;
    private bool is_shooting = false;

    private void Start()
    {
        InvokeRepeating("SpawnBulletRate", 0f, 60 / shoot_bpm);
    }

    private void SpawnBulletRate()
    {
        if (is_shooting)
        {
            Instantiate(bulletPrefab, spawnBulletPoint.position, spawnBulletPoint.rotation);
        }
    }

    public void BeAgressive()
    {
        transform.Rotate(0f, 180f, 0f);//look to player
        is_shooting = true;
    }

}
