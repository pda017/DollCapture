using System.Collections;
using UnityEngine;

public class CollectionItemIndexChanged
{
    int m_Dirty = int.MinValue;
    public bool Check()
    {
        if (m_Dirty != CollectionData.ItemIndex.m_Value)
        {
            m_Dirty = CollectionData.ItemIndex.m_Value;
            return true;
        }
        return false;
    }
}