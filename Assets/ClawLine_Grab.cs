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
    // Start is called before the first frame update
    void Start()
    {
        
        m_Owner = GetComponentInParent<Owner>().m_Value;
        var rootTf = m_Owner.GetComponentInParent<RootTag>().transform;
        m_FSM = new FSM(m_Owner);
        m_ClawGrab = rootTf.GetComponentInChildren<ClawGrab>();
        m_GrabTime = rootTf.GetComponentInChildren<GrabTime>();
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
                if (m_WaitTime.End(m_GrabTime.m_Value))
                {
                    m_FSM.SetState(StateEnum.Up);
                    return;
                }
            }
        }
    }
}
