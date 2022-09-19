using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcadeCase_Claw : MonoBehaviour
{
    ClawGrab m_ClawGrab;
    GrabAngle m_GrabAngle;
    HingeJoint m_HingeJoint;
    int m_NumState = 0;
    private void Start()
    {
        m_HingeJoint = GetComponent<HingeJoint>();
        m_GrabAngle = GetComponentInParent<GrabAngle>();
        m_ClawGrab = GetComponentInParent<ClawGrab>();
    }
    private void Update()
    {
        var spring = m_HingeJoint.spring;
        if (m_ClawGrab.m_Value)
            spring.targetPosition = m_GrabAngle.m_GrabAngle;
        else
            spring.targetPosition = m_GrabAngle.m_ReleaseAngle;

        m_HingeJoint.spring = spring;
    }
    private void OnCollisionStay(Collision collision)
    {
        if (CheckLayerContains.Check(LayerData.CaseFloor.m_Value, collision.collider.gameObject.layer))
        {
            ArcadeClawData.FloorColDirty.m_Value++;
        }
    }
}
