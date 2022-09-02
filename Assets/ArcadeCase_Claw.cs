using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcadeCase_Claw : MonoBehaviour
{
    private void OnCollisionStay(Collision collision)
    {
        if (CheckLayerContains.Check(LayerData.CaseFloor.m_Value, collision.collider.gameObject.layer))
        {
            ArcadeClawData.FloorColDirty.m_Value++;
        }
    }
}
