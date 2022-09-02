using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcadeCase_Stick : MonoBehaviour
{
    Transform m_Tf;
    // Start is called before the first frame update
    void Start()
    {
        m_Tf = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (MoveStickData.IsTouch.m_Value)
        {
            var right = Vector3.Cross(Vector3.up, MoveStickData.DirXZ.m_Value);
            m_Tf.rotation = Quaternion.AngleAxis(MoveStickData.MoveSpeedRate.m_Value * ArcadeCaseData.StickAngleLimit.m_Value, right);
        }
        else
        {
            m_Tf.rotation = Quaternion.identity;
        }
    }
}
