using System.Collections;
using UnityEngine;

public class DioramaItemIndexChanged
{
    int m_Dirty = int.MinValue;
    public bool Check()
    {
        if (m_Dirty != DioramaData.ItemIndex.m_Value)
        {
            m_Dirty = DioramaData.ItemIndex.m_Value;
            return true;
        }
        return false;
    }
}