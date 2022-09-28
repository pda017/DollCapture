using System.Collections;
using UnityEngine;

public class GetItemListChanged
{
    float m_Dirty = float.MinValue;
    public bool Check()
    {
        if (m_Dirty != ArcadeCaseData.GetItemList.m_Dirty)
        {
            m_Dirty = ArcadeCaseData.GetItemList.m_Dirty;
            return true;
        }
        return false;
    }
}