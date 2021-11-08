using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    //nice
    [SerializeField]private float damage = 20f;
    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            PlayerStats.instance.PlayerTakeDamage(damage);
        }
    }
}
