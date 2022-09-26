using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvenPanel_PageText : MonoBehaviour
{
    ZText m_Text;
    InventoryChanged m_InvenChanged;
    InvenPageChanged m_InvenPageChanged;
    // Start is called before the first frame update
    void Start()
    {
        m_InvenPageChanged = new InvenPageChanged();
        m_InvenChanged = new InventoryChanged();
        m_Text = new ZText(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (m_InvenChanged.Check() || m_InvenPageChanged.Check())
        {
            var fullPage = Mathf.CeilToInt(InvenData.Inventory.m_Value.Count / (float)InvenData.PageNodeNum.m_Value);
            m_Text.SetText("{0}/{1}",InvenData.Page.m_Value + 1,fullPage);
        }
    }
}
