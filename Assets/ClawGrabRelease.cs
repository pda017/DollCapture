using System.Collections;
using UnityEngine;

public class ClawGrabRelease
{
    ClawGrab m_ClawGrab;
    public ClawGrabRelease(GameObject owner)
    {
        var rootTf = owner.GetComponentInParent<RootTag>().transform;
        m_ClawGrab = rootTf.GetComponentInChildren<ClawGrab>();
    }
    public void Set(bool releaseClaw = true)
    {
        if (releaseClaw)
        {
            m_ClawGrab.m_Value = false;
            m_ClawGrab.m_Dirty++;
        }
    }
}