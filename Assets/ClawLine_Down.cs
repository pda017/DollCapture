using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawLine_Down : MonoBehaviour
{
    ClawGrab m_ClawGrab;
    GameObject m_Owner;
    FSM m_FSM;
    ArcadeCase_Line m_Line;
    CheckColCadeFloor m_CheckColCadeFloor;
    CheckDollCol m_CheckDollCol;
    
    // Start is called before the first frame update
    void Start()
    {
        m_CheckColCadeFloor = new CheckColCadeFloor();
        m_Owner = GetComponentInParent<Owner>().m_Value;
        m_FSM = new FSM(m_Owner);
        m_Line = m_Owner.GetComponent<ArcadeCase_Line>();
        m_CheckDollCol = new CheckDollCol();
        m_ClawGrab = m_Owner.GetComponentInChildren<ClawGrab>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_FSM.Begin(StateEnum.Down))
        {
            if (m_FSM.BeginNumState(0))
            {
                m_ClawGrab.m_Value = false;
                m_ClawGrab.m_Dirty++;
                m_CheckDollCol.Check();
                m_CheckColCadeFloor.Check();
                m_FSM.NextNumState();
            }
            else if (m_FSM.BeginNumState(1))
            {
                m_Line.Down();
                if (m_CheckColCadeFloor.Check())
                {
                    m_FSM.SetState(StateEnum.Up);
                    return;
                }
                if (m_CheckDollCol.Check())
                {
                    m_FSM.SetState(StateEnum.Grab);
                    return;
                }
            }
        }
    }
}