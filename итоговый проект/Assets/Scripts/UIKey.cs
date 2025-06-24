using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIKey : MonoBehaviour
{
    [SerializeField] private Bag bag;
    [SerializeField] private Text text;


    private void Start()
    {
        bag.ChangeAmountKey.AddListener(OnChangeKey);
    }

    private void OnDestroy()
    {
        bag.ChangeAmountKey.RemoveListener(OnChangeKey);
    }

    private void OnChangeKey()
    {
        text.text = bag.GetAmountKey().ToString();
    }
}
