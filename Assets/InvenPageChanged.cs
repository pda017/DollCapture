using System.Collections;
using UnityEngine;

public class InvenPageChanged
{
    public int m_Dirty = int.MinValue;
    public bool Check()
    {
        if (m_Dirty != InvenData.Page.m_Value)
        {
            m_Dirty = InvenData.Page.m_Value;
            return true;
        }
        return false;
    }
}