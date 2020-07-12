using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyReactions : MonoBehaviour
{
    private float life = 10;
    public GameObject effect;

    public void TakeDamage(float damage)
    {
        life -= damage;
        if (life<=0)
        {
            Die();
        }
    }
    private void Die()
    {
        Instantiate(effect,transform.position,Quaternion.identity);
        Destroy(gameObject);
    }
}
