using System.Collections;
using UnityEngine;

public class CheckClawLeftWallCol
{
    float m_Dirty = float.MinValue;
    public bool Check()
    {
        if (m_Dirty != ArcadeClawData.LeftWallColDirty.m_Value)
        {
            m_Dirty = ArcadeClawData.LeftWallColDirty.m_Value;
            return true;
        }
        return false;
    }
}