using System.Collections;
using UnityEngine;

public class CamRotateData
{
    static Data_FloatRange m_AngleLimit;
    public static Data_FloatRange AngleLimit
    {
        get
        {
            if (m_AngleLimit == null)
                m_AngleLimit = Resources.Load<Data_FloatRange>("Data/CamRotate/AngleLimit");
            return m_AngleLimit;
        }
    }
    static Data_Float m_RotSpeed;
    public static Data_Float RotSpeed
    {
        get
        {
            if (m_RotSpeed == null)
                m_RotSpeed = Resources.Load<Data_Float>("Data/CamRotate/RotSpeed");
            return m_RotSpeed;
        }
    }
    static Data_Bool m_IsPush;
    public static Data_Bool IsPush
    {
        get
        {
            if (m_IsPush == null)
                m_IsPush = Resources.Load<Data_Bool>("Data/CamRotate/IsPush");
            return m_IsPush;
        }
    }
    static Data_Vector3 m_MoveDelta;
    public static Data_Vector3 MoveDelta
    {
        get
        {
            if (m_MoveDelta == null)
                m_MoveDelta = Resources.Load<Data_Vector3>("Data/CamRotate/MoveDelta");
            return m_MoveDelta;
        }
    }
}