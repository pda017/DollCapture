using System.Collections.Generic;

public class GetCharPartsInfo
{
    public static Dictionary<string, CharPartsInfo> m_Dic = null;
    public static Dictionary<string, CharPartsInfo> GetDic()
    {
        if (m_Dic == null)
        {
            m_Dic = new Dictionary<string, CharPartsInfo>();
            CharPartsData.CharPartsList.m_Value.ForEach(v =>
            {
                m_Dic.Add(v.m_Key, v);
            });
        }
        return m_Dic;
    }
    public static CharPartsInfo Get(string key)
    {
        CharPartsInfo value;
        GetDic().TryGetValue(key, out value);
        return value;
    }
     
}
