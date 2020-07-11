using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class BulletBehaviuor : MonoBehaviour
{
    //references
    [SerializeField] private float bullet_speed = 20f;
    private Rigidbody2D bulletrb = null;
    //variables
    private float time_to_live = 3f;
    void Start()
    {
        //propagation
        bulletrb = GetComponent<Rigidbody2D>();
        bulletrb.velocity = transform.right * bullet_speed;
        //auto destruction
        Destroy(gameObject, time_to_live);
    }
}
