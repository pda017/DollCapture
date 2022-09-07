using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcadeCase_ClawFrame : MonoBehaviour
{
    Transform m_Tf;
    State m_LineState;
    ClawMoveSpeed m_ClawMoveSpeed;
    ClawPosClamp m_ClawPosClamp;
    ClawAutoMove m_ClawAutoMove;
    ClawDest m_ClawDest;
    // Start is called before the first frame update
    void Start()
    {
        m_ClawDest = GetComponentInParent<ClawDest>();
        m_Tf = transform;
        m_LineState = GetComponentInChildren<ClawLineTag>().GetComponent<State>();
        m_ClawMoveSpeed = GetComponentInParent<ClawMoveSpeed>();
        m_ClawPosClamp = new ClawPosClamp(gameObject);
        m_ClawAutoMove = GetComponentInParent<ClawAutoMove>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_ClawAutoMove.m_Value)
        {
            var look = m_ClawDest.m_Value - m_Tf.position;
            look.y = 0;
            var dir = look.normalized;
            m_Tf.Translate(0,0,dir.z * m_ClawMoveSpeed.m_Value * Time.deltaTime, Space.World);
            m_ClawPosClamp.ClampZ();
            return;
        }

        if (m_LineState.m_Value != StateEnum.Idle)
            return;

        if (MoveStickData.IsTouch.m_Value)
        {
            m_Tf.Translate(0,0
                ,MoveStickData.DirXZ.m_Value.z * m_ClawMoveSpeed.m_Value * MoveStickData.MoveSpeedRate.m_Value * Time.deltaTime
                ,Space.World);
        }
        m_ClawPosClamp.ClampZ();
    }
}
