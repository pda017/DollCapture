using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStickData
{
    static Data_Float m_InnerRadius;
    public static Data_Float InnerRadius
    {
        get
        {
            if (m_InnerRadius == null)
                m_InnerRadius = Resources.Load<Data_Float>("Data/MoveStick/InnerRadius");
            return m_InnerRadius;
        }
    }
    static Data_Vector3 m_DirXZ;
    public static Data_Vector3 DirXZ
    {
        get
        {
            if (m_DirXZ == null)
                m_DirXZ = Resources.Load<Data_Vector3>("Data/MoveStick/DirXZ");
            return m_DirXZ;
        }
    }
    static Data_Vector3 m_ClampedEndPos;
    public static Data_Vector3 ClampedEndPos
    {
        get
        {
            if (m_ClampedEndPos == null)
                m_ClampedEndPos = Resources.Load<Data_Vector3>("Data/MoveStick/ClampedEndPos");
            return m_ClampedEndPos;
        }
    }
    static Data_Vector2 m_OriRtPos;
    public static Data_Vector2 OriRtPos
    {
        get
        {
            if (m_OriRtPos == null)
                m_OriRtPos = Resources.Load<Data_Vector2>("Data/MoveStick/OriRtPos");
            return m_OriRtPos;
        }
    }
    static Data_Vector3 m_Dir;
    public static Data_Vector3 Dir
    {
        get
        {
            if (m_Dir == null)
                m_Dir = Resources.Load<Data_Vector3>("Data/MoveStick/Dir");
            return m_Dir;
        }
    }
    static Data_Float m_Dist;
    public static Data_Float Dist
    {
        get
        {
            if (m_Dist == null)
                m_Dist = Resources.Load<Data_Float>("Data/MoveStick/Dist");
            return m_Dist;
        }
    }
    static Data_Vector3 m_EndPos;
    public static Data_Vector3 EndPos
    {
        get
        {
            if (m_EndPos == null)
                m_EndPos = Resources.Load<Data_Vector3>("Data/MoveStick/EndPos");
            return m_EndPos;
        }
    }
    static Data_Bool m_IsTouch;
    public static Data_Bool IsTouch
    {
        get
        {
            if (m_IsTouch == null)
                m_IsTouch = Resources.Load<Data_Bool>("Data/MoveStick/IsTouch");
            return m_IsTouch;
        }
    }
    static Data_Float m_MoveSpeedRate;
    public static Data_Float MoveSpeedRate
    {
        get
        {
            if (m_MoveSpeedRate == null)
                m_MoveSpeedRate = Resources.Load<Data_Float>("Data/MoveStick/MoveSpeedRate");
            return m_MoveSpeedRate;
        }
    }
    static Data_Float m_Radius;
    public static Data_Float Radius
    {
        get
        {
            if (m_Radius == null)
                m_Radius = Resources.Load<Data_Float>("Data/MoveStick/Radius");
            return m_Radius;
        }
    }
    static Data_Vector3 m_StartPos;
    public static Data_Vector3 StartPos
    {
        get
        {
            if (m_StartPos == null)
                m_StartPos = Resources.Load<Data_Vector3>("Data/MoveStick/StartPos");
            return m_StartPos;
        }
    }
}
