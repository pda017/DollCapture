using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectItemPanel_ItemName : MonoBehaviour
{
    ZText m_Text;
    SelectItemIndexChanged m_IndexChanged;
    InventoryChanged m_InvenChanged;
    // Start is called before the first frame update
    void Start()
    {
        m_InvenChanged = new InventoryChanged();
        m_Text = new ZText(gameObject);
        m_IndexChanged = new SelectItemIndexChanged();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_IndexChanged.Check() || m_InvenChanged.Check())
        {
            var itemInfo = GetInvenItemInfo.Get(InvenData.SelectIndex.m_Value);
            if (itemInfo != null)
            {
                m_Text.SetText(itemInfo.m_Name);
            }
        }
    }
}
