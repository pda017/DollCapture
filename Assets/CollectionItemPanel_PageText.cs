using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionItemPanel_PageText : MonoBehaviour
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
            if (CollectionData.SelectedCollection.m_Value < CollectionData.CollectionList.m_Value.Count)
            {
                var collectionInfo = CollectionData.CollectionList.m_Value[CollectionData.SelectedCollection.m_Value];
                var count = collectionInfo.m_ItemList.Count;
                m_Text.SetText("{0}/{1}", CollectionData.ItemIndex.m_Value + 1, count);
            }
        }
    }
}
