using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipHealth : Health
{
    public GameObject explosionPrefab;

    protected override void Die()
    {
        base.Die();
        Debug.Log("Ship died");
        
        if (explosionPrefab != null)
        {
            var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(explosion, 1);
        }
        
        Destroy(gameObject);
    }
}
