using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class BulletBehaviuor : MonoBehaviour
{
    [SerializeField] private float bullet_speed = 20f;
    private Rigidbody2D bulletrb = null;
    // Start is called before the first frame update
    void Start()
    {
        bulletrb = GetComponent<Rigidbody2D>();
        bulletrb.velocity = transform.right * bullet_speed;
    }
}
