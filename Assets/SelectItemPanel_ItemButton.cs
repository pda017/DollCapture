using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SelectItemPanel_ItemButton : MonoBehaviour
{
    RawImage m_Image;
    DioramaItemIndexChanged m_ItemIndexChanged;
    InventoryChanged m_InvenChanged;
    // Start is called before the first frame update
    void Start()
    {
        m_Image = GetComponent<RawImage>();
        m_ItemIndexChanged = new DioramaItemIndexChanged();
        m_InvenChanged = new InventoryChanged();
        ButtonEvent.AddClickEvent(gameObject, () =>
        {
            if (AddObjToDioramaRoom.AddSelected())
            {
                PanelMgr.HideCanvas("SelectItemPanel");
                PanelMgr.ShowCanvas("EditItemPanel");
                SetState.Set("Diorama", StateEnum.ModifyItem);
            }
        });
    }
    private void Update()
    {
        if (m_ItemIndexChanged.Check() || m_InvenChanged.Check())
        {
            var itemInfo = GetInvenItemInfo.Get(DioramaData.ItemIndex.m_Value);
            if (itemInfo != null)
            {
                m_Image.enabled = true;
                var iconInfo = GetItemIcon.Get(itemInfo.m_Key);
                if (iconInfo != null)
                    m_Image.texture = iconInfo.m_Tex;
            }
            else
                m_Image.enabled = false;
        }
    }
}
