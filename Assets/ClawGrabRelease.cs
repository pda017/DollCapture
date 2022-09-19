using System.Collections;
using UnityEngine;

public class ClawGrabRelease
{
    Transform m_SuckPointTf;
    ClawGrab m_ClawGrab;
    public ClawGrabRelease(GameObject owner)
    {
        var rootTf = owner.GetComponentInParent<RootTag>().transform;
        var suckPointTag = rootTf.GetComponentInChildren<SuckPointTag>();
        m_SuckPointTf = suckPointTag.transform;
        m_ClawGrab = rootTf.GetComponentInChildren<ClawGrab>();
    }
    public void Set(bool releaseClaw = true)
    {
        m_SuckPointTf.DetachChildren();
        if (releaseClaw)
        {
            m_ClawGrab.m_Value = false;
            m_ClawGrab.m_Dirty++;
        }
    }
}