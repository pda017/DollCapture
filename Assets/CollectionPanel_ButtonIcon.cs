using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CollectionPanel_ButtonIcon : MonoBehaviour
{
    RawImage m_Image;
    ItemListChanged m_ItemListChanged;
    Transform m_IndexTf;
    CollectionPageChanged m_CollectionPageChanged;
    // Start is called before the first frame update
    void Start()
    {
        m_CollectionPageChanged = new CollectionPageChanged();
        m_IndexTf = GetComponentInParent<IndexTag>().transform;
        m_ItemListChanged = new ItemListChanged();
        m_Image = GetComponent<RawImage>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_ItemListChanged.Check() || m_CollectionPageChanged.Check())
        {
            var index = m_IndexTf.GetSiblingIndex() + (CollectionData.Page.m_Value * CollectionData.PageNodeNum.m_Value);
            if (index < CollectionData.CollectionList.m_Value.Count)
            {
                m_Image.enabled = true;
                var collectInfo = CollectionData.CollectionList.m_Value[index];
                if (collectInfo.m_ItemList.Count != 0)
                {
                    bool isCollect = false;
                    for (int i = 0; i < collectInfo.m_ItemList.Count; i++)
                    {
                        var itemKey = collectInfo.m_ItemList[i];
                        var itemInfo = GetItemInfo.Get(itemKey);
                        if (itemInfo.m_IsCollected)
                        {
                            var iconInfo = GetItemIcon.Get(itemKey);
                            if (iconInfo != null)
                            {
                                m_Image.color = Color.white;
                                m_Image.texture = iconInfo.m_Tex;
                                isCollect = true;
                                break;
                            }
                        }
                    }

                    if (!isCollect)
                    {
                        var itemKey = collectInfo.m_ItemList[0];
                        var iconInfo = GetItemIcon.Get(itemKey);
                        if (iconInfo != null)
                        {
                            m_Image.color = Color.black;
                            m_Image.texture = iconInfo.m_Tex;
                        }
                    }
                }
            }
            else
                m_Image.enabled = false;
        }
    }
}
