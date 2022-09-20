using System.Collections;
using UnityEngine;

public class CamZoomData
{
    static Data_Float m_Speed;
    public static Data_Float Speed
    {
        get
        {
            if (m_Speed == null)
                m_Speed = Resources.Load<Data_Float>("Data/CamZoom/Speed");
            return m_Speed;
        }
    }
    static Data_Float m_Delta;
    public static Data_Float Delta
    {
        get
        {
            if (m_Delta == null)
                m_Delta = Resources.Load<Data_Float>("Data/CamZoom/Delta");
            return m_Delta;
        }
    }
    static Data_Bool m_IsPush;
    public static Data_Bool IsPush
    {
        get
        {
            if (m_IsPush == null)
                m_IsPush = Resources.Load<Data_Bool>("Data/CamZoom/IsPush");
            return m_IsPush;
        }
    }
    static Data_FloatRange m_Limit;
    public static Data_FloatRange Limit
    {
        get
        {
            if (m_Limit == null)
                m_Limit = Resources.Load<Data_FloatRange>("Data/CamZoom/Limit");
            return m_Limit;
        }
    }
}