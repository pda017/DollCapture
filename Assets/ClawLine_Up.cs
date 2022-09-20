using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawLine_Up : MonoBehaviour
{
    GameObject m_Owner;
    FSM m_FSM;
    ArcadeCase_Line m_Line;
    // Start is called before the first frame update
    void Start()
    {
        m_Owner = GetComponentInParent<Owner>().m_Value;
        var rootTf = m_Owner.GetComponentInParent<RootTag>().transform;
        m_FSM = new FSM(m_Owner);
        m_Line = m_Owner.GetComponent<ArcadeCase_Line>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_FSM.Begin(StateEnum.Up))
        {
            if (m_FSM.BeginNumState(0))
            {
                if (m_Line.Up())
                {
                    m_FSM.SetState(StateEnum.DropDoll);
                }
            }
        }
    }
}
