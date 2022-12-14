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
        var rootTf = GetComponentInParent<RootTag>().transform;
        m_ClawDest = GetComponentInParent<ClawDest>();
        m_Tf = transform;
        m_LineState = rootTf.GetComponentInChildren<ClawLineTag>().GetComponent<State>();
        m_ClawMoveSpeed = GetComponentInParent<ClawMoveSpeed>();
        m_ClawPosClamp = new ClawPosClamp(gameObject);
        m_ClawAutoMove = GetComponentInParent<ClawAutoMove>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (m_ClawAutoMove.m_Value)
        {
            var look = m_ClawDest.m_Value - m_Tf.position;
            look.y = 0;
            var dist = Mathf.Abs(look.z);
            var dir = look.normalized;
            var moveAmount = m_ClawMoveSpeed.m_Value * Time.deltaTime;
            if (moveAmount >= dist)
            {
                ArcadeClawData.ClawOnDropPosZ.m_Value = true;
                m_Tf.Translate(0, 0, dir.z * dist, Space.World);
            }
            else
            {
                ArcadeClawData.ClawOnDropPosZ.m_Value = false;
                m_Tf.Translate(0, 0, dir.z * moveAmount, Space.World);
            }
            m_ClawPosClamp.ClampZ();
            return;
        }

        if (m_LineState.m_Value != StateEnum.Idle)
            return;

        if (MoveStickData.IsTouch.m_Value)
        {
            var camDir = MoveStickDirToCamDir.Get();
            m_Tf.Translate(0,0
                , camDir.z * m_ClawMoveSpeed.m_Value * MoveStickData.MoveSpeedRate.m_Value * Time.deltaTime
                ,Space.World);
        }
        m_ClawPosClamp.ClampZ();
    }
}
