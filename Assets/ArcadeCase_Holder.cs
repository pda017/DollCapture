using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcadeCase_Holder : MonoBehaviour
{
    public float m_MoveSpeed = 1;
    Transform m_Tf;
    Collider m_ClawLimitBounds;
    Collider m_ClawBounds;
    State m_LineState;
    // Start is called before the first frame update
    void Start()
    {
        m_Tf = transform;
        var rootTf = GetComponentInParent<RootTag>().transform;
        m_ClawLimitBounds = rootTf.GetComponentInChildren<ClawLimitBoundsTag>().GetComponent<Collider>();
        m_ClawBounds = rootTf.GetComponentInChildren<ClawBoundsTag>().GetComponent<Collider>();
        m_LineState = GetComponentInChildren<ClawLineTag>().GetComponent<State>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_LineState.m_Value != StateEnum.Idle)
            return;

        if(MoveStickData.IsTouch.m_Value)
            m_Tf.position += MoveStickData.DirXZ.m_Value * m_MoveSpeed * MoveStickData.MoveSpeedRate.m_Value * Time.deltaTime;

        var clawBounds = m_ClawBounds.bounds;
        var clawLimitBounds = m_ClawLimitBounds.bounds;

        var dt = Vector3.zero;
        if (clawBounds.min.x < clawLimitBounds.min.x)
            dt.x += clawLimitBounds.min.x - clawBounds.min.x;
        if (clawBounds.max.x > clawLimitBounds.max.x)
            dt.x += clawLimitBounds.max.x - clawBounds.max.x;
        if (clawBounds.min.z < clawLimitBounds.min.z)
            dt.z += clawLimitBounds.min.z - clawBounds.min.z;
        if (clawBounds.max.z > clawLimitBounds.max.z)
            dt.z += clawLimitBounds.max.z - clawBounds.max.z;

        m_Tf.position += dt;
    }
}
