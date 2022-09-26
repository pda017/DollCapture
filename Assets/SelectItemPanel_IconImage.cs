using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SelectItemPanel_IconImage : MonoBehaviour
{
    RawImage m_Image;
    SelectItemIndexChanged m_IndexChanged;
    InventoryChanged m_InvenChanged;
    // Start is called before the first frame update
    void Start()
    {
        m_Image = GetComponent<RawImage>();
        m_InvenChanged = new InventoryChanged();
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
                var iconInfo = GetItemIcon.Get(itemInfo.m_Key);
                if(iconInfo != null)
                    m_Image.texture = iconInfo.m_Tex;
            }
        }
    }
}
