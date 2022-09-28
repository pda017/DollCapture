using System.Collections;
using UnityEngine;

public class GetInvenItemInfo
{
    public static ItemInfo Get(int index)
    {
        if (index < InvenData.Inventory.m_Value.Count)
        {
            var key = InvenData.Inventory.m_Value[index];
            return GetItemInfo.Get(key);
        }
        return null;
    }
}