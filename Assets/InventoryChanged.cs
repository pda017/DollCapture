using System.Collections;
using UnityEngine;

public class InventoryChanged
{
    float m_Dirty = float.MinValue;
    public bool Check()
    {
        if (m_Dirty != InvenData.Inventory.m_Dirty)
        {
            m_Dirty = InvenData.Inventory.m_Dirty;
            return true;
        }
        return false;
    }
}