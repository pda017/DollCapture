using System.Collections;
using UnityEngine;

public class SelectedCollectionChanged
{
    int m_Dirty = int.MinValue;
    public bool Check()
    {
        if (m_Dirty != CollectionData.SelectedCollection.m_Value)
        {
            m_Dirty = CollectionData.SelectedCollection.m_Value;
            return true;
        }
        return false;
    }
}