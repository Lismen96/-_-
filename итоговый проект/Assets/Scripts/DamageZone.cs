using SimpleFPS;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class DamageZone : MonoBehaviour
{
    [SerializeField]private int damage;
    [SerializeField]private float damageRate;

    private Destructible destructible;
    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;

        if(timer >= damageRate)
        {
            if (destructible != null)
            {
                destructible.AppltDamage(damage);
            }


            timer = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        destructible = other.GetComponent<Destructible>();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Destructible>() == destructible) destructible = null;
    }
}
