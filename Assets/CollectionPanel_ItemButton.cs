using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionPanel_ItemButton : MonoBehaviour
{
    Transform m_IndexTf;
    // Start is called before the first frame update
    void Start()
    {
        m_IndexTf = GetComponentInParent<IndexTag>().transform;
        ButtonEvent.AddClickEvent(gameObject, () =>
        {
            var index = m_IndexTf.GetSiblingIndex() + (CollectionData.Page.m_Value * CollectionData.PageNodeNum.m_Value);
            if (index < CollectionData.CollectionList.m_Value.Count)
            {
                CollectionData.ItemIndex.m_Value = 0;
                CollectionData.SelectedCollection.m_Value = index;
                PanelMgr.ShowCanvas("CollectionItemPanel");
            }
        });
    }
}
