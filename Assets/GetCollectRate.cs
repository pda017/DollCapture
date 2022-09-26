using System.Collections;
using UnityEngine;

public class GetCollectRate
{
    public static float Get()
    {
        int fullCount = 0;
        int collectCount = 0;
        CollectionData.CollectionList.m_Value.ForEach(v =>
        {
            fullCount += v.m_ItemList.Count;
            v.m_ItemList.ForEach(itemKey =>
            {
                var itemInfo = GetItemInfo.Get(itemKey);
                if (itemInfo.m_IsCollected)
                    collectCount++;
            });
        });
        if (fullCount == 0)
            return 0;
        return Mathf.Clamp01(collectCount / (float)fullCount);
    }
}