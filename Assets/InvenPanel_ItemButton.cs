using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvenPanel_ItemButton : MonoBehaviour
{
    Transform m_Tf;
    // Start is called before the first frame update
    void Start()
    {
        m_Tf = transform;
        ButtonEvent.AddClickEvent(gameObject, () =>
        {
            var index = m_Tf.GetSiblingIndex() + (InvenData.Page.m_Value * InvenData.PageNodeNum.m_Value);
            if (index < InvenData.Inventory.m_Value.Count)
            {
                if (InvenData.SellAllMode.m_Value)
                {
                    if (InvenData.SellList.m_Value.Contains(index))
                        InvenData.SellList.m_Value.Remove(index);
                    else
                        InvenData.SellList.m_Value.Add(index);
                }
                else
                {
                    InvenData.SelectIndex.m_Value = index;
                    PanelMgr.ShowCanvas("SelectItemPanel");
                }
            }
        });
    }
}
