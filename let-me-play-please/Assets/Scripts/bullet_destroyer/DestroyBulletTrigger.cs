using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBulletTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        BulletBehaviuor bullet = collision.GetComponent<BulletBehaviuor>();
        bullet?.DestroyBullet();
    }
}
