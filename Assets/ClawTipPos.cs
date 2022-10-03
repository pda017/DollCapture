using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawTipPos : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (CheckLayerContains.Check(LayerData.DropBounds.m_Value, other.gameObject.layer))
            ArcadeClawData.DropBoundsClawTipColDirty.m_Value++;
    }
}
