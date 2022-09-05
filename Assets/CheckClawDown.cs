using System.Collections;
using UnityEngine;

public class CheckClawDown
{
    float m_Dirty = float.MinValue;
    public bool Check()
    {
        if (m_Dirty != ArcadeClawData.DownDirty.m_Value)
        {
            m_Dirty = ArcadeClawData.DownDirty.m_Value;
            return true;
        }
        return false;
    }
}