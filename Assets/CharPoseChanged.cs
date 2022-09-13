using System.Collections;
using UnityEngine;

public class CharPoseChanged
{
    CharPose m_CharPose;
    float m_Dirty = float.MinValue;
    public CharPoseChanged(GameObject owner)
    {
        m_CharPose = owner.GetComponentInParent<CharPose>();
    }
    public bool Check()
    {
        if (m_Dirty != m_CharPose.m_Dirty)
        {
            m_Dirty = m_CharPose.m_Dirty;
            return true;
        }
        return false;
    }
}
