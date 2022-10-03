using System.Collections;
using UnityEngine;
using System.Collections.Generic;
public class GetArcadeInfo
{
    static Dictionary<string, ArcadeInfo> m_Dic = null;
    public static ArcadeInfo Get(string key)
    {
        if (m_Dic == null)
        {
            var list = ArcadeCaseData.ArcadeList.m_Value;
            m_Dic = new Dictionary<string, ArcadeInfo>();
            list.ForEach(v =>
            {
                m_Dic.Add(v.m_Key, v);
            });
        }

        ArcadeInfo value;
        m_Dic.TryGetValue(key, out value);
        return value;
    }
    public static ArcadeInfo Get(int index)
    {
        if (index < ArcadeCaseData.ArcadeList.m_Value.Count)
        {
            return ArcadeCaseData.ArcadeList.m_Value[index];
        }
        return null;
    }
}