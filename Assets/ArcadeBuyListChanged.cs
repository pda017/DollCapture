using System.Collections;
using UnityEngine;

public class ArcadeBuyListChanged
{
    float m_Dirty = float.MinValue;
    public bool Check()
    {
        if (m_Dirty != ArcadeCaseData.BuyList.m_Dirty)
        {
            m_Dirty = ArcadeCaseData.BuyList.m_Dirty;
            return true;
        }
        return false;
    }
}