using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcadeCase_Claw : MonoBehaviour
{
    ClawGrab m_ClawGrab;
    GrabAngle m_GrabAngle;
    HingeJoint m_HingeJoint;
    GrabSpeed m_GrabSpeed;
    int m_NumState = 0;
    private void Start()
    {
        m_GrabSpeed = GetComponentInParent<GrabSpeed>();
        m_HingeJoint = GetComponent<HingeJoint>();
        m_GrabAngle = GetComponentInParent<GrabAngle>();
        m_ClawGrab = GetComponentInParent<ClawGrab>();
    }
    private void Update()
    {
        var spring = m_HingeJoint.spring;
        if (m_ClawGrab.m_Value)
            spring.targetPosition += m_GrabSpeed.m_Value * Time.deltaTime;
        else
            spring.targetPosition -= m_GrabSpeed.m_Value * Time.deltaTime;
        spring.targetPosition = Mathf.Clamp(spring.targetPosition, m_GrabAngle.m_ReleaseAngle, m_GrabAngle.m_GrabAngle);
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
