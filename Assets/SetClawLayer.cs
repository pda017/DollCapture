using System.Collections;
using UnityEngine;
using System.Collections.Generic;
public class SetClawLayer
{
    List<Collider> m_ClawLegList = new List<Collider>();
    public SetClawLayer(GameObject owner)
    {
        var rootTag = owner.GetComponentInParent<RootTag>();
        var mainClawTag = rootTag.GetComponentInChildren<MainClawTag>();
        m_ClawLegList.AddRange(mainClawTag.GetComponentsInChildren<Collider>());
    }
    public void Set(string layerName)
    {
        int layer = LayerMask.NameToLayer(layerName);
        m_ClawLegList.ForEach(v =>
        {
            v.gameObject.layer = layer;
        });
    }
}