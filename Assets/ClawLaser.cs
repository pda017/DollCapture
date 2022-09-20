using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawLaser : MonoBehaviour
{
    Raycast m_Raycast;
    Transform m_Tf;
    MeshRenderer m_Mr;
    State m_LineState;
    Transform m_Parent;
    // Start is called before the first frame update
    void Start()
    {
        var rootTag = GetComponentInParent<RootTag>();
        var clawLineTag = rootTag.GetComponentInChildren<ClawLineTag>();
        m_LineState = clawLineTag.GetComponent<State>();
        m_Mr = GetComponent<MeshRenderer>();
        m_Tf = transform;
        m_Parent = transform.parent;
        m_Raycast = new Raycast();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_LineState.m_Value == StateEnum.Idle)
        {
            m_Mr.enabled = true;
            if (m_Raycast.Check(m_Parent.position, Vector3.down, 2, LayerData.CaseFloor.m_Value | LayerData.Doll.m_Value))
            {
                var hit = m_Raycast.m_HitList[0];
                var dist = hit.distance;
                var lineDist = m_Mr.bounds.size.y;
                var dt = dist / lineDist;
                var scale = m_Parent.localScale;
                scale.y *= dt;
                m_Parent.localScale = scale;
            }
        }
        else
            m_Mr.enabled = false;
    }
}
