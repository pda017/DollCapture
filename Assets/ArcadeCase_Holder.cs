using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcadeCase_Holder : MonoBehaviour
{
    Transform m_Tf;
    State m_LineState;
    ClawMoveSpeed m_ClawMoveSpeed;
    ClawAutoMove m_ClawAutoMove;
    ClawDest m_ClawDest;
    ClawPosClamp m_ClawPosClamp;
    // Start is called before the first frame update
    void Start()
    {
        var rootTf = GetComponentInParent<RootTag>().transform;
        m_ClawDest = GetComponentInParent<ClawDest>();
        m_ClawAutoMove = GetComponentInParent<ClawAutoMove>();
        m_Tf = transform;
        m_LineState = rootTf.GetComponentInChildren<ClawLineTag>().GetComponent<State>();
        m_ClawMoveSpeed = GetComponentInParent<ClawMoveSpeed>();
        m_ClawPosClamp = new ClawPosClamp(gameObject);
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (m_ClawAutoMove.m_Value)
        {
            var look = m_ClawDest.m_Value - m_Tf.position;
            look.y = 0;
            var dir = look.normalized;
            m_Tf.Translate(dir.x * m_ClawMoveSpeed.m_Value * Time.deltaTime, 0, 0, Space.World);
            m_ClawPosClamp.ClampX();
            return;
        }

        if (m_LineState.m_Value != StateEnum.Idle)
            return;

        if (MoveStickData.IsTouch.m_Value)
        {
            m_Tf.Translate(MoveStickData.DirXZ.m_Value.x * m_ClawMoveSpeed.m_Value * MoveStickData.MoveSpeedRate.m_Value * Time.deltaTime
                , 0, 0, Space.World);
        }

        m_ClawPosClamp.ClampX();
    }
}
