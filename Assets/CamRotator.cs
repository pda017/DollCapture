using System.Collections;
using UnityEngine;

public class CamRotator
{
    Transform m_Tf;
    Quaternion m_XRot;
    float m_YAngle;
    public CamRotator(GameObject owner)
    {
        m_Tf = owner.transform;
    }
    public void InitRot()
    {
        var worldForward = m_Tf.forward;
        worldForward.y = 0;
        worldForward.Normalize();
        m_XRot = Quaternion.LookRotation(worldForward, Vector3.up);
        m_YAngle = Vector3.SignedAngle(worldForward, m_Tf.forward, m_Tf.right);
    }
    public void Update(Vector3 moveDelta,float speed,float minAngle,float maxAngle)
    {
        m_XRot *= Quaternion.Euler(0, moveDelta.x * speed, 0);
        m_YAngle = Mathf.Clamp(m_YAngle - (moveDelta.y * speed), minAngle, maxAngle);
        m_Tf.rotation = m_XRot;
        m_Tf.Rotate(m_YAngle, 0, 0, Space.Self);
    }
}