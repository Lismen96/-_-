using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactAffect : MonoBehaviour
{
    [SerializeField] private float timer;

    private void Start()
    {
        Destroy(gameObject,timer);
    }
}
