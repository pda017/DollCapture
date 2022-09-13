using System.Collections;
using UnityEngine;
using System.Collections.Generic;
public class GetCharPartsInfoByType
{
    static Dictionary<CharPartsEnum, List<CharPartsInfo>> m_Dic = null;
    static void Init()
    {
        if (m_Dic == null)
        {
            m_Dic = new Dictionary<CharPartsEnum, List<CharPartsInfo>>();
            CharPartsData.CharPartsList.m_Value.ForEach(v =>
            {
                List<CharPartsInfo> partsList;
                if (!m_Dic.TryGetValue(v.m_Type, out partsList))
                {
                    partsList = new List<CharPartsInfo>();
                    m_Dic.Add(v.m_Type, partsList);
                }
                partsList.Add(v);
            });
        }
    }
    public static List<CharPartsInfo> Get(CharPartsEnum partsType)
    {
        Init();
        List<CharPartsInfo> value;
        m_Dic.TryGetValue(partsType, out value);
        return value;
    }
}