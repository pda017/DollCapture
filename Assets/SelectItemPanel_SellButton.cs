using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectItemPanel_SellButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ButtonEvent.AddClickEvent(gameObject, () =>
        {
            var itemInfo = GetInvenItemInfo.Get(InvenData.SelectIndex.m_Value);
            if (itemInfo != null)
            {
                InvenData.Token.m_Value += itemInfo.m_Cost;
                InvenData.Inventory.m_Value.RemoveAt(InvenData.SelectIndex.m_Value);
                InvenData.Inventory.m_Dirty++;
                PanelMgr.HideCanvas("SelectItemPanel");
            }
        });
    }
}
