using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPoints : Pikup
{
    [SerializeField] private int healing;
    private Destructible destructible;
    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);

        destructible = other.GetComponent<Destructible>();

        if (destructible != null)
        {
            destructible.hitPoints += healing;
            destructible.ChangeHitPoints.Invoke();
        }
    }
}
