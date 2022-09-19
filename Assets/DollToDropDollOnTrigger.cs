using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollToDropDollOnTrigger : MonoBehaviour
{
    DollToDropDoll m_DollToDropDoll;
    // Start is called before the first frame update
    void Start()
    {
        m_DollToDropDoll = new DollToDropDoll();
    }
    private void OnTriggerStay(Collider other)
    {
        if (CheckLayerContains.Check(LayerData.Doll.m_Value, other.gameObject.layer))
        {
            var rigid = other.GetComponentInParent<Rigidbody>();
            m_DollToDropDoll.Set(rigid);
        }
    }
}
