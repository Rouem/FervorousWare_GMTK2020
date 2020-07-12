using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyReactions : MonoBehaviour
{
    private float life = 10;

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
        Destroy(gameObject);
    }
}
