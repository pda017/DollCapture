using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doll_DropDoll : MonoBehaviour
{
    FSM m_FSM;
    GameObject m_Owner;
    Transform m_DropDollPos;
    Rigidbody m_Rigid;
    Transform m_Tf;
    // Start is called before the first frame update
    void Start()
    {
        m_Owner = GetComponentInParent<Owner>().m_Value;
        m_FSM = new FSM(m_Owner);
        m_DropDollPos = Finder.FindObject("DollDropPos").transform;
        m_Rigid = m_Owner.GetComponent<Rigidbody>();
        m_Tf = m_Owner.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (m_FSM.Begin(StateEnum.DropDoll))
        {
            if (m_FSM.BeginNumState(0))
            {
                var vel = m_Rigid.velocity;
                vel.x = 0;
                vel.z = 0;
                m_Rigid.velocity = vel;
                if (m_Tf.position.y < m_DropDollPos.position.y)
                {
                    Destroy(m_Owner);
                }
            }
        }
    }
}
