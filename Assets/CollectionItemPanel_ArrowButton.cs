using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionItemPanel_ArrowButton : MonoBehaviour
{
    public int m_Dir;
    // Start is called before the first frame update
    void Start()
    {
        ButtonEvent.AddClickEvent(gameObject, () =>
        {
            if (CollectionData.SelectedCollection.m_Value < CollectionData.CollectionList.m_Value.Count)
            {
                var collectionInfo = CollectionData.CollectionList.m_Value[CollectionData.SelectedCollection.m_Value];
                var count = collectionInfo.m_ItemList.Count;
                var index = CollectionData.ItemIndex.m_Value;
                index += m_Dir;
                if (index < 0)
                    index = count - 1;
                if (index >= count)
                    index = 0;
                CollectionData.ItemIndex.m_Value = index;
            }
        });
    }
}
