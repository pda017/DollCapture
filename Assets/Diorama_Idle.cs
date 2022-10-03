using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diorama_Idle : MonoBehaviour
{
    GameObject m_Owner;
    FSM m_FSM;
    // Start is called before the first frame update
    void Start()
    {
        m_Owner = GetComponentInParent<Owner>().m_Value;
        m_FSM = new FSM(m_Owner);
    }

    // Update is called once per frame
    void Update()
    {
        if (m_FSM.Begin(StateEnum.Idle))
        {
            if (m_FSM.BeginNumState(0))
            {
                DioramaData.ItemIndex.m_Value = 0;
                m_FSM.NextNumState();
            }
        }
    }
}
