using System.Collections;
using UnityEngine;

public class ArcadeCaseData
{
    static Data_StringList m_GetItemList;
    public static Data_StringList GetItemList
    {
        get
        {
            if (m_GetItemList == null)
                m_GetItemList = Resources.Load<Data_StringList>("Data/ArcadeCase/GetItemList");
            return m_GetItemList;
        }
    }
    static Data_ArcadeList m_ArcadeList;
    public static Data_ArcadeList ArcadeList
    {
        get
        {
            if (m_ArcadeList == null)
                m_ArcadeList = Resources.Load<Data_ArcadeList>("Data/ArcadeCase/ArcadeList");
            return m_ArcadeList;
        }
    }
    static Data_Float m_StickAngleLimit;
    public static Data_Float StickAngleLimit
    {
        get
        {
            if (m_StickAngleLimit == null)
                m_StickAngleLimit = Resources.Load<Data_Float>("Data/ArcadeCase/StickAngleLimit");
            return m_StickAngleLimit;
        }
    }
}