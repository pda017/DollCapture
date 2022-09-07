using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawLine_DropDoll : MonoBehaviour
{
    GameObject m_Owner;
    FSM m_FSM;
    CheckClawLeftWallCol m_LeftWallCol;
    CheckClawBackWallCol m_BackWallCol;
    ClawGrab m_ClawGrab;
    WaitTime m_WaitTime;
    Transform m_DollDropPos;
    ClawDest m_ClawDest;
    ClawAutoMove m_ClawAutoMove;
    // Start is called before the first frame update
    void Start()
    {
        m_WaitTime = new WaitTime();
        m_LeftWallCol = new CheckClawLeftWallCol();
        m_BackWallCol = new CheckClawBackWallCol();
        m_Owner = GetComponentInParent<Owner>().m_Value;
        m_FSM = new FSM(m_Owner);
        m_ClawDest = m_Owner.GetComponentInParent<ClawDest>();
        m_ClawAutoMove = m_Owner.GetComponentInParent<ClawAutoMove>();
        m_DollDropPos = Finder.FindObject("DollDropPos").transform;
        m_ClawGrab = m_Owner.GetComponentInChildren<ClawGrab>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_FSM.Begin(StateEnum.DropDoll))
        {
            if (m_FSM.BeginNumState(0))
            {
                m_ClawAutoMove.m_Value = true;
                m_ClawAutoMove.m_Dirty++;
                m_ClawDest.m_Value = m_DollDropPos.position;
                m_ClawDest.m_Dirty++;
                m_LeftWallCol.Check();
                m_BackWallCol.Check();
                m_FSM.NextNumState();
            }
            else if (m_FSM.BeginNumState(1))
            {
                if (m_BackWallCol.Check() || m_LeftWallCol.Check())
                {
                    m_WaitTime.Start();
                    m_FSM.NextNumState();
                }
            }
            else if (m_FSM.BeginNumState(2))
            {
                if (m_WaitTime.End(ArcadeClawData.DropReadyTime.m_Value))
                {
                    var grabDoll = InstMgr.Get(ArcadeClawData.GrabDoll_Id.m_Value);
                    if (grabDoll != null)
                    {
                        var dollTf = grabDoll.transform;
                        var dollRigid = grabDoll.GetComponent<Rigidbody>();
                        dollTf.parent = null;
                        dollRigid.isKinematic = false;
                    }
                    m_WaitTime.Start();
                    m_ClawGrab.m_Value = false;
                    m_ClawGrab.m_Dirty++;
                    m_FSM.NextNumState();
                }
            }
            else if (m_FSM.BeginNumState(3))
            {
                if (m_WaitTime.End(ArcadeClawData.DropTime.m_Value))
                {
                    m_ClawGrab.m_Value = true;
                    m_ClawGrab.m_Dirty++;
                    m_FSM.SetState(StateEnum.Idle);
                }
            }
        }
    }
}
