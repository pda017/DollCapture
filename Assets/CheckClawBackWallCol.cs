using System.Collections;
using UnityEngine;

public class CheckClawBackWallCol
{
    float m_Dirty = float.MinValue;
    public bool Check()
    {
        if (m_Dirty != ArcadeClawData.BackWallColDirty.m_Value)
        {
            m_Dirty = ArcadeClawData.BackWallColDirty.m_Value;
            return true;
        }
        return false;
    }
}