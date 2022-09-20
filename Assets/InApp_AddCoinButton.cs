using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InApp_AddCoinButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ButtonEvent.AddClickEvent(gameObject, () =>
        {
            InvenData.Coin.m_Value += 10;
        });
    }
}
