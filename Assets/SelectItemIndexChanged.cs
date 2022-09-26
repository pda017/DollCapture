using System.Collections;
using UnityEngine;

public class SelectItemIndexChanged
{
    int m_Dirty = int.MinValue;
    public bool Check()
    {
        if (m_Dirty != InvenData.SelectIndex.m_Value)
        {
            m_Dirty = InvenData.SelectIndex.m_Value;
            return true;
        }
        return false;
    }
}