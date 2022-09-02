using System.Collections;
using UnityEngine;

public class ArcadeCaseData
{
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