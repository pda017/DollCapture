using System.Collections;
using UnityEngine;
using System.Collections.Generic;
public class SellAllItem
{
    public static void Set()
    {
        var newList = new List<string>();
        for (int i = 0; i < InvenData.Inventory.m_Value.Count; i++)
        {
            var value = InvenData.Inventory.m_Value[i];
            if (InvenData.SellList.m_Value.Contains(i))
            {
                var itemInfo = GetItemInfo.Get(value);
                InvenData.Token.m_Value += itemInfo.m_Cost;
            }
            else
                newList.Add(value);
        }
        InvenData.Inventory.m_Value = newList;
        InvenData.Inventory.m_Dirty++;
    }
}