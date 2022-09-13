using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharPartsChanged
{
    float m_Dirty = float.MinValue;
    CharParts m_CharParts;
    public CharPartsChanged(GameObject owner)
    {
        m_CharParts = owner.GetComponentInParent<CharParts>();
    }
    public bool Check()
    {
        if (m_Dirty != m_CharParts.m_Dirty)
        {
            m_Dirty = m_CharParts.m_Dirty;
            return true;
        }
        return false;
    }
}
