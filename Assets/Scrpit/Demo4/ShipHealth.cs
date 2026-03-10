using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipHealth : Health
{
    protected override void Die()
    {
        base.Die();
        Debug.Log("Ship died");
    }
}
