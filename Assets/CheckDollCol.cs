using System.Collections;
using UnityEngine;

public class CheckDollCol
{
    float m_Dirty = float.MinValue;
    public bool Check()
    {
        if (m_Dirty != ArcadeClawData.DollColDirty.m_Value)
        {
            m_Dirty = ArcadeClawData.DollColDirty.m_Value;
            return true;
        }
        return false;
    }
}