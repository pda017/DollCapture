using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionItemPanel_ItemDesc : MonoBehaviour
{
    ZText m_Text;
    SelectedCollectionChanged m_SelectedCollectionChanged;
    CollectionItemIndexChanged m_CollectionItemIndexChanged;
    ItemListChanged m_ItemListChanged;
    // Start is called before the first frame update
    void Start()
    {
        m_ItemListChanged = new ItemListChanged();
        m_CollectionItemIndexChanged = new CollectionItemIndexChanged();
        m_SelectedCollectionChanged = new SelectedCollectionChanged();
        m_Text = new ZText(gameObject);
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
                if (itemInfo.m_IsCollected)
                    m_Text.SetText(itemInfo.m_Desc);
                else
                    m_Text.SetText("?");
            }
        }
    }
}
