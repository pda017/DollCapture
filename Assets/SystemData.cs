using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemData
{
    static Data_Int m_TargetFps;
    public static Data_Int TargetFps
    {
        get
        {
            if (m_TargetFps == null)
                m_TargetFps = Resources.Load<Data_Int>("Data/System/TargetFps");
            return m_TargetFps;
        }
    }
    static Data_Vector2 m_TargetResolution;
    public static Data_Vector2 TargetResolution
    {
        get
        {
            if (m_TargetResolution == null)
                m_TargetResolution = Resources.Load<Data_Vector2>("Data/System/TargetResolution");
            return m_TargetResolution;
        }
    }
}
