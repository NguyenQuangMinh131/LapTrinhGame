using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab;
    public int defaultHealthPoint = 100;
    public System.Action onDead;

    private int currentHealth;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        currentHealth = defaultHealthPoint;
    }

    public void TakeDamage(int damage)  
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        if (explosionPrefab != null)
        {
            var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(explosion, 1);
        }
        
        Destroy(gameObject);
        onDead?.Invoke();
    }
}