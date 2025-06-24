using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyTrigger : MonoBehaviour
{
    [SerializeField] private GameObject massegeBox;
    [SerializeField] private UnityEvent enter;
    [SerializeField] private int AmountKeyActive;

    private bool isActive = false;

    protected  void OnTriggerEnter(Collider other)
    {
        if (isActive == true) return;
        Bag bag = other.GetComponent<Bag>();

        if (bag != null)
        {
            if(bag.DrawKey(AmountKeyActive) == true)
            {
                enter.Invoke();
                isActive = true;
            }
            else
            {
                massegeBox.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        massegeBox.SetActive(false);
    }
}
