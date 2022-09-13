using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawLine_Grab : MonoBehaviour
{
    ClawGrab m_ClawGrab;
    GrabTime m_GrabTime;
    FSM m_FSM;
    GameObject m_Owner;
    WaitTime m_WaitTime;
    Transform m_SuckPointTf;
    Raycast m_Raycast;
    IsGrabbed m_IsGrabbed;
    // Start is called before the first frame update
    void Start()
    {
        
        m_Raycast = new Raycast();
        m_Owner = GetComponentInParent<Owner>().m_Value;
        var rootTf = m_Owner.GetComponentInParent<RootTag>().transform;
        m_FSM = new FSM(m_Owner);
        m_ClawGrab = rootTf.GetComponentInChildren<ClawGrab>();
        m_GrabTime = rootTf.GetComponentInChildren<GrabTime>();
        m_WaitTime = new WaitTime();
        var suckPointTag = rootTf.GetComponentInChildren<SuckPointTag>();
        m_SuckPointTf = suckPointTag.transform;
        m_IsGrabbed = rootTf.GetComponentInChildren<IsGrabbed>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_FSM.Begin(StateEnum.Grab))
        {
            if (m_FSM.BeginNumState(0))
            {
                m_ClawGrab.m_Value = true;
                m_ClawGrab.m_Dirty++;
                m_WaitTime.Start();
                m_FSM.NextNumState();
            }
            else if (m_FSM.BeginNumState(1))
            {
                if (m_WaitTime.End(m_GrabTime.m_Value))
                {
                    if (m_Raycast.Check(m_SuckPointTf.position, Vector3.down, ArcadeClawData.GrabCheckDist.m_Value, LayerData.Doll.m_Value, false))
                    {
                        m_IsGrabbed.m_Value = true;
                        m_IsGrabbed.m_Dirty++;
                        var dollRigid = m_Raycast.m_HitList[0].collider.GetComponentInParent<Rigidbody>();
                        var dollTf = dollRigid.transform;
                        dollTf.parent = m_SuckPointTf;
                        //dollRigid.isKinematic = true;
                        ArcadeClawData.GrabDoll_Id.m_Value = dollRigid.gameObject.GetInstanceID();
                    }
                    m_FSM.SetState(StateEnum.Up);
                    return;
                }
            }
        }
    }
}
