using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : Pikup
{
    [SerializeField] private GameObject ImpactEffect;
    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);

        Bag bag = other.GetComponent<Bag>();

        if(bag != null)
        {
            bag.AddKey(1);
            Instantiate(ImpactEffect);
        }
    }
}
