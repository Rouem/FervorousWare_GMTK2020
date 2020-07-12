using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleEnemy : MonoBehaviour
{
    public Transform player;
    public Transform firePoint;
    float fireRate;
    public GameObject bullet, effect;
    public int life;
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {

        if(player == null || !player.gameObject.activeInHierarchy) return;

        if(life <= 0){
            Instantiate(effect,transform.position,Quaternion.identity);
            Destroy(gameObject);
        }

        if(player.position.x > transform.position.x)
            transform.eulerAngles.Set(0,0,0);
        
        if(player.position.x < transform.position.x)
            transform.eulerAngles.Set(0,180f,0);

        if(Vector3.Distance(transform.position,player.position) < 5f){
            if(fireRate > 1f){
                fireRate = 0;
                Instantiate(bullet,firePoint.position, firePoint.rotation);
            }else
                fireRate += Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.transform.tag.Equals("playerBullet"))
            life--;
    }
}
