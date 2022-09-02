using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawLine_Down : MonoBehaviour
{
    GameObject m_Owner;
    FSM m_FSM;
    ArcadeCase_Line m_Line;
    CheckColCadeFloor m_CheckColCadeFloor;
    // Start is called before the first frame update
    void Start()
    {
        m_CheckColCadeFloor = new CheckColCadeFloor();
        m_Owner = GetComponentInParent<Owner>().m_Value;
        m_FSM = new FSM(m_Owner);
        m_Line = m_Owner.GetComponent<ArcadeCase_Line>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_FSM.Begin(StateEnum.Down))
        {
            if (m_FSM.BeginNumState(0))
            {
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
            }
        }
    }
}
