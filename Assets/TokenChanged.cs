using System.Collections;
using UnityEngine;

public class TokenChanged
{
    int m_Dirty = int.MinValue;
    public bool Check()
    {
        if (m_Dirty != InvenData.Token.m_Value)
        {
            m_Dirty = InvenData.Token.m_Value;
            return true;
        }
        return false;
    }
}