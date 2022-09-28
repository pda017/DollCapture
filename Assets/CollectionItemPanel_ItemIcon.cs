using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CollectionItemPanel_ItemIcon : MonoBehaviour
{
    RawImage m_Image;
    SelectedCollectionChanged m_SelectedCollectionChanged;
    CollectionItemIndexChanged m_CollectionItemIndexChanged;
    ItemListChanged m_ItemListChanged;
    // Start is called before the first frame update
    void Start()
    {
        m_ItemListChanged = new ItemListChanged();
        m_CollectionItemIndexChanged = new CollectionItemIndexChanged();
        m_SelectedCollectionChanged = new SelectedCollectionChanged();
        m_Image = GetComponent<RawImage>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_SelectedCollectionChanged.Check()
            || m_CollectionItemIndexChanged.Check()
            || m_ItemListChanged.Check())
        {
            var itemKey = GetCurCollectionItem.Get();
            var itemInfo = GetItemInfo.Get(itemKey);
            if (itemInfo != null)
            {
                var itemIcon = GetItemIcon.Get(itemKey);
                if (itemIcon != null)
                {
                    m_Image.texture = itemIcon.m_Tex;
                    if (itemInfo.m_IsCollected)
                        m_Image.color = Color.white;
                    else
                        m_Image.color = Color.black;
                }
            }
        }
    }
}
