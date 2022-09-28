using System.Collections;
using UnityEngine;

public class CollectionPageChanged
{
    int m_Dirty = int.MinValue;
    public bool Check()
    {
        if (m_Dirty != CollectionData.Page.m_Value)
        {
            m_Dirty = CollectionData.Page.m_Value;
            return true;
        }
        return false;
    }
}