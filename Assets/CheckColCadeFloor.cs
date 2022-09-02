using System.Collections;
using UnityEngine;

public class CheckColCadeFloor
{
    float m_Dirty = float.MinValue;
    public bool Check()
    {
        if (m_Dirty != ArcadeClawData.FloorColDirty.m_Value)
        {
            m_Dirty = ArcadeClawData.FloorColDirty.m_Value;
            return true;
        }
        return false;
    }
}