using System.Collections;
using UnityEngine;
using System.Collections.Generic;
public class GetItemInfo
{
    static Dictionary<string, ItemInfo> m_Dic = null;
    public static ItemInfo Get(string key)
    {
        if (m_Dic == null)
        {
            m_Dic = new Dictionary<string, ItemInfo>();
            ItemData.ItemList.m_Value.ForEach(v =>
            {
                m_Dic.Add(v.m_Key, v);
            });
        }

        ItemInfo value;
        m_Dic.TryGetValue(key, out value);
        return value;
    }
}