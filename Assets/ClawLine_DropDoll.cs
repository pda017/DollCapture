using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawLine_DropDoll : MonoBehaviour
{
    GameObject m_Owner;
    FSM m_FSM;
    CheckClawLeftWallCol m_LeftWallCol;
    CheckClawBackWallCol m_BackWallCol;
    WaitTime m_WaitTime;
    Transform m_DollDropPos;
    ClawDest m_ClawDest;
    ClawAutoMove m_ClawAutoMove;
    ClawGrabRelease m_ClawGrabRelease;
    OverlapSphere m_OverlapSphere;
    Transform m_SuckPointTf;
    DollToDropDoll m_DollToDropDoll;
    bool m_bSuccess;
    // Start is called before the first frame update
    void Start()
    {
        m_OverlapSphere = new OverlapSphere();
        m_WaitTime = new WaitTime();
        m_LeftWallCol = new CheckClawLeftWallCol();
        m_BackWallCol = new CheckClawBackWallCol();
        m_Owner = GetComponentInParent<Owner>().m_Value;
        var rootTf = m_Owner.GetComponentInParent<RootTag>().transform;
        m_FSM = new FSM(m_Owner);
        m_ClawDest = rootTf.GetComponentInChildren<ClawDest>();
        m_ClawAutoMove = rootTf.GetComponentInChildren<ClawAutoMove>();
        m_DollDropPos = rootTf.GetComponentInChildren<DollDropPosTag>().transform;
        m_ClawGrabRelease = new ClawGrabRelease(m_Owner);
        m_SuckPointTf = rootTf.GetComponentInChildren<SuckPointTag>().transform;
        m_DollToDropDoll = new DollToDropDoll();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_FSM.Begin(StateEnum.DropDoll))
        {
            if (m_FSM.BeginNumState(0))
            {
                m_bSuccess = false;
                m_ClawAutoMove.m_Value = true;
                m_ClawAutoMove.m_Dirty++;
                m_ClawDest.m_Value = m_DollDropPos.position;
                m_ClawDest.m_Dirty++;
                CheckClawOnDropPos.Start();
                m_LeftWallCol.Check();
                m_BackWallCol.Check();
                m_FSM.NextNumState();
            }
            else if (m_FSM.BeginNumState(1))
            {
                if ((m_BackWallCol.Check() && m_LeftWallCol.Check())
                    || CheckClawOnDropPos.Check())
                {
                    m_WaitTime.Start();
                    m_FSM.NextNumState();
                }
            }
            else if (m_FSM.BeginNumState(2))
            {
                if (m_WaitTime.End(ArcadeClawData.DropReadyTime.m_Value))
                {
                    var hitList = m_OverlapSphere.Check(m_SuckPointTf.position + new Vector3(0, -ArcadeClawData.DropCheckDist.m_Value)
                        , ArcadeClawData.DropCheckRadius.m_Value, LayerData.Doll.m_Value);

                    if (hitList.Count != 0)
                    {
                        hitList.ForEach(v =>
                        {
                            var rigid = v.GetComponentInParent<Rigidbody>();
                            m_DollToDropDoll.Set(rigid);
                        });
                        m_bSuccess = true;
                    }

                    if (!m_bSuccess)
                    {
                        PanelMgr.HideCanvas("ControllerPanel");
                        PanelMgr.ShowCanvas("RetryPanel");
                    }

                    m_ClawGrabRelease.Set();
                    m_WaitTime.Start();
                    m_FSM.NextNumState();
                }
            }
            else if (m_FSM.BeginNumState(3))
            {
                if (m_WaitTime.End(ArcadeClawData.DropTime.m_Value))
                {
                    if (ArcadeCaseData.GetItemList.m_Value.Count != 0)
                    {
                        PanelMgr.ShowCanvas("GetItemPanel",true);
                    }
                    m_FSM.SetState(StateEnum.Idle);
                }
            }
        }
    }
}
