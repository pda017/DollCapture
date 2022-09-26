using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvenPanel_SellAllButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ButtonEvent.AddClickEvent(gameObject, () =>
        {
            InvenData.SellList.m_Value.Clear();

            InvenData.SellAllMode.m_Value = true;
            InvenData.SellAllMode.m_Dirty++;

        });
    }
}
