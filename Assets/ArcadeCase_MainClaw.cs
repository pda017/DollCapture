using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcadeCase_MainClaw : MonoBehaviour
{
    private void OnCollisionStay(Collision collision)
    {
        if (CheckLayerContains.Check(LayerData.Doll.m_Value, collision.collider.gameObject.layer))
            ArcadeClawData.DollColDirty.m_Value++;
    }
}
