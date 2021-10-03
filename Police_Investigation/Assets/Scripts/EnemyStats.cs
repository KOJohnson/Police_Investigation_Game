using UnityEngine;

public class EnemyStats : MonoBehaviour
{
   public float health = 100f;

    public void TakeDamage(float Damage)
    {
        health -= Damage;

        if(health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        Debug.Log("Enemy Killed");
    }
}
