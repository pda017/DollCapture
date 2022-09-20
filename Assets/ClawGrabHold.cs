using System.Collections;
using UnityEngine;

public class ClawGrabHold
{
    Transform m_SuckPointTf;
    IsGrabbed m_IsGrabbed;
    Raycast m_Raycast;
    public ClawGrabHold(GameObject owner)
    {
        m_Raycast = new Raycast();
        var rootTf = owner.GetComponentInParent<RootTag>().transform;
        var suckPointTag = rootTf.GetComponentInChildren<SuckPointTag>();
        m_SuckPointTf = suckPointTag.transform;
        m_IsGrabbed = rootTf.GetComponentInChildren<IsGrabbed>();
    }
    public bool Set()
    {
        if (m_Raycast.Check(m_SuckPointTf.position, Vector3.down, ArcadeClawData.GrabCheckDist.m_Value, LayerData.Doll.m_Value, false))
        {
            m_SuckPointTf.DetachChildren();
            m_IsGrabbed.m_Value = true;
            m_IsGrabbed.m_Dirty++;
            for (int i = 0; i < m_Raycast.m_HitList.Count; i++)
            {
                var hit = m_Raycast.m_HitList[i];
                var dollRigid = hit.collider.GetComponentInParent<Rigidbody>();
                var dollTf = dollRigid.transform;
                //dollTf.parent = m_SuckPointTf;
                ArcadeClawData.GrabDoll_Id.m_Value = dollRigid.gameObject.GetInstanceID();
            }
            return true;
        }
        return false;
    }
}