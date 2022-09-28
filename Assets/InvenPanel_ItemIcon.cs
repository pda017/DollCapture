using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InvenPanel_ItemIcon : MonoBehaviour
{
    Transform m_IndexTf;
    RawImage m_Image;
    InventoryChanged m_InventoryChanged;
    InvenPageChanged m_InvenPageChanged;
    // Start is called before the first frame update
    void Start()
    {
        m_InvenPageChanged = new InvenPageChanged();
        m_IndexTf = GetComponentInParent<IndexTag>().transform;
        m_InventoryChanged = new InventoryChanged();
        m_Image = GetComponent<RawImage>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_InventoryChanged.Check()
            || m_InvenPageChanged.Check())
        {
            var index = m_IndexTf.GetSiblingIndex() + (InvenData.Page.m_Value * InvenData.PageNodeNum.m_Value); 
            var itemInfo = GetInvenItemInfo.Get(index);
            if (itemInfo != null)
            {
                m_Image.enabled = true;
                var iconInfo = GetItemIcon.Get(itemInfo.m_Key);
                if(iconInfo != null)
                    m_Image.texture = iconInfo.m_Tex;
            }
            else
            {
                m_Image.enabled = false;
            }
        }
    }
}
