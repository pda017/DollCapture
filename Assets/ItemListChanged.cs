using System.Collections;
using UnityEngine;

public class ItemListChanged
{
    float m_Dirty = float.MinValue;
    public bool Check()
    {
        if (m_Dirty != ItemData.ItemList.m_Dirty)
        {
            m_Dirty = ItemData.ItemList.m_Dirty;
            return true;
        }
        return false;
    }
}