using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellModePanel_OkButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ButtonEvent.AddClickEvent(gameObject, () =>
        {
            SellAllItem.Set();
            InvenData.SellAllMode.m_Value = false;
            InvenData.SellAllMode.m_Dirty++;
        });
    }
}
