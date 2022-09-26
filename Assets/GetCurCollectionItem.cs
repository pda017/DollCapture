using System.Collections;
using UnityEngine;

public class GetCurCollectionItem
{
    public static string Get()
    {
        if (CollectionData.SelectedCollection.m_Value < CollectionData.CollectionList.m_Value.Count)
        {
            var collectionInfo = CollectionData.CollectionList.m_Value[CollectionData.SelectedCollection.m_Value];
            if (CollectionData.ItemIndex.m_Value < collectionInfo.m_ItemList.Count)
            {
                var itemKey = collectionInfo.m_ItemList[CollectionData.ItemIndex.m_Value];
                return itemKey;
            }
        }
        return string.Empty;
    }
}