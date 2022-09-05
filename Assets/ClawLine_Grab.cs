using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawLine_Grab : MonoBehaviour
{
    ClawGrab m_ClawGrab;
    IsGrabbed m_IsGrabbed;
    FSM m_FSM;
    GameObject m_Owner;
    WaitTime m_WaitTime;
    // Start is called before the first frame update
    void Start()
    {
        m_Owner = GetComponentInParent<Owner>().m_Value;
        m_FSM = new FSM(m_Owner);
        m_ClawGrab = m_Owner.GetComponentInChildren<ClawGrab>();
        m_IsGrabbed = m_Owner.GetComponentInChildren<IsGrabbed>();
        m_WaitTime = new WaitTime();
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
                if (m_IsGrabbed.m_Value && m_WaitTime.End(2))
                {
                    m_FSM.SetState(StateEnum.Up);
                    return;
                }
            }
        }
    }
}
