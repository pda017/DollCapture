using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawLine_Idle : MonoBehaviour
{
    FSM m_FSM;
    GameObject m_Owner;
    ArcadeCase_Line m_Line;
    CheckClawDown m_CheckClawDown;
    // Start is called before the first frame update
    void Start()
    {
        m_Owner = GetComponentInParent<Owner>().m_Value;
        m_FSM = new FSM(m_Owner);
        m_Line = m_Owner.GetComponent<ArcadeCase_Line>();
        m_CheckClawDown = new CheckClawDown();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_FSM.Begin(StateEnum.Idle))
        {
            if (m_FSM.BeginNumState(0))
            {
                m_CheckClawDown.Check();
                m_FSM.NextNumState();
            }
            else if (m_FSM.BeginNumState(1))
            {
                if (m_CheckClawDown.Check())
                {
                    m_FSM.SetState(StateEnum.Down);
                    return;
                }
            }
        }
    }
}
