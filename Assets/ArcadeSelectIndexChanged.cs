using System.Collections;
using UnityEngine;

public class ArcadeSelectIndexChanged
{
    int m_Dirty = int.MinValue;
    public bool Check()
    {
        if (m_Dirty != ArcadeCaseData.SelectedArcadeIndex.m_Value)
        {
            m_Dirty = ArcadeCaseData.SelectedArcadeIndex.m_Value;
            return true;
        }
        return false;
    }
}