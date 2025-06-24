using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Destructible : MonoBehaviour
{
    [SerializeField] private int maxHitPoints;

    public UnityEvent Die;
    public UnityEvent ChangeHitPoints;
    [HideInInspector] public int hitPoints;

    private void Start()
    {
        hitPoints = maxHitPoints;
        ChangeHitPoints.Invoke();
    }

    public void AppltDamage(int damage)
    {
        ChangeHitPoints.Invoke();
        hitPoints -= damage;

        

        if (hitPoints <= 0)
        {
            Kill();
        }
    }

    public void Kill()
    {
        hitPoints = 0;
        ChangeHitPoints.Invoke();
        Die.Invoke();
    }

    public int GetHitPoints()
    {
        return hitPoints;
    }
    public int GetMaxHitPoints()
    {
        return maxHitPoints;
    }
}
