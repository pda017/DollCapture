using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawLine_Down : MonoBehaviour
{
    GameObject m_Owner;
    FSM m_FSM;
    ArcadeCase_Line m_Line;
    CheckColCadeFloor m_CheckColCadeFloor;
    CheckDollCol m_CheckDollCol;
    IsGrabbed m_IsGrabbed;
    CheckDropBoundsClawTipCol m_CheckDropBoundsCol;
    // Start is called before the first frame update
    void Start()
    {
        m_CheckColCadeFloor = new CheckColCadeFloor();
        m_Owner = GetComponentInParent<Owner>().m_Value;
        m_FSM = new FSM(m_Owner);
        var rootTf = m_Owner.GetComponentInParent<RootTag>().transform;
        m_Line = m_Owner.GetComponent<ArcadeCase_Line>();
        m_CheckDollCol = new CheckDollCol();
        m_IsGrabbed = rootTf.GetComponentInChildren<IsGrabbed>();
        m_CheckDropBoundsCol = new CheckDropBoundsClawTipCol();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_FSM.Begin(StateEnum.Down))
        {
            if (m_FSM.BeginNumState(0))
            {
                m_IsGrabbed.m_Value = false;
                m_IsGrabbed.m_Dirty++;
                m_CheckDollCol.Check();
                m_CheckColCadeFloor.Check();
                m_CheckDropBoundsCol.Check();
                m_FSM.NextNumState();
            }
            else if (m_FSM.BeginNumState(1))
            {
                m_Line.Down();
                if (m_CheckColCadeFloor.Check()
                    || m_CheckDropBoundsCol.Check()
                    || m_CheckDollCol.Check())
                {
                    m_FSM.SetState(StateEnum.Grab);
                    return;
                }
            }
        }
    }
}
