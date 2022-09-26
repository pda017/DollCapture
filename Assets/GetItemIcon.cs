using System.Collections;
using UnityEngine;
using System.Collections.Generic;
public class GetItemIcon
{
    static Dictionary<string, IconInfo> m_Dic = null;
    public static IconInfo Get(string key)
    {
        if (m_Dic == null)
        {
            m_Dic = new Dictionary<string, IconInfo>();
            ItemData.IconList.m_Value.ForEach(v =>
            {
                m_Dic.Add(v.m_Key, v);
            });
        }

        IconInfo value;
        m_Dic.TryGetValue(key, out value);
        return value;
    }
}