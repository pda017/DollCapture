using System.Collections;
using UnityEngine;

public class SelectedCollectionChanged
{
    float m_Dirty = float.MinValue;
    public bool Check()
    {
        if (m_Dirty != CollectionData.CollectionList.m_Dirty)
        {
            m_Dirty = CollectionData.CollectionList.m_Dirty;
            return true;
        }
        return false;
    }
}