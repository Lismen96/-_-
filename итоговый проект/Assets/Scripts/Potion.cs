using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : Pikup
{
    [SerializeField] private GameObject ImpactEffect;
    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
        Instantiate(ImpactEffect);
        
    }
}
