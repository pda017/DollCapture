using System.Collections;
using UnityEngine;

public class ClawPosClamp
{
    Collider m_ClawLimitBounds;
    Collider m_ClawBounds;
    Transform m_Tf;
    public ClawPosClamp(GameObject owner)
    {
        m_Tf = owner.transform;
        var rootTf = owner.GetComponentInParent<RootTag>().transform;
        m_ClawLimitBounds = rootTf.GetComponentInChildren<ClawLimitBoundsTag>().GetComponent<Collider>();
        m_ClawBounds = rootTf.GetComponentInChildren<ClawBoundsTag>().GetComponent<Collider>();
    }
    public void ClampX()
    {
        var clawBounds = m_ClawBounds.bounds;
        var clawLimitBounds = m_ClawLimitBounds.bounds;

        var dt = Vector3.zero;
        if (clawBounds.min.x < clawLimitBounds.min.x)
        {
            ArcadeClawData.LeftWallColDirty.m_Value++;
            dt.x += clawLimitBounds.min.x - clawBounds.min.x;
        }
        if (clawBounds.max.x > clawLimitBounds.max.x)
        {
            ArcadeClawData.RightWallColDirty.m_Value++;
            dt.x += clawLimitBounds.max.x - clawBounds.max.x;
        }

        m_Tf.position += dt;
    }
    public void ClampZ()
    {
        var clawBounds = m_ClawBounds.bounds;
        var clawLimitBounds = m_ClawLimitBounds.bounds;

        var dt = Vector3.zero;
        if (clawBounds.min.z < clawLimitBounds.min.z)
        {
            ArcadeClawData.BackWallColDirty.m_Value++;
            dt.z += clawLimitBounds.min.z - clawBounds.min.z;
        }
        if (clawBounds.max.z > clawLimitBounds.max.z)
        {
            ArcadeClawData.ForwardWallColDirty.m_Value++;
            dt.z += clawLimitBounds.max.z - clawBounds.max.z;
        }

        m_Tf.position += dt;
    }
    public void Clamp()
    {
        ClampX();
        ClampZ();
    }
}