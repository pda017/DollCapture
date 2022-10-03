using System.Collections;
using UnityEngine;

public class CheckDropBoundsClawTipCol
{
    float m_Dirty = float.MinValue;
    public bool Check()
    {
        if (m_Dirty != ArcadeClawData.DropBoundsClawTipColDirty.m_Value)
        {
            m_Dirty = ArcadeClawData.DropBoundsClawTipColDirty.m_Value;
            return true;
        }
        return false;
    }
}