using System.Collections;
using UnityEngine;

public class DollToDropDoll
{
    int m_DropDollLayer;
    public DollToDropDoll()
    {
        m_DropDollLayer = LayerMask.NameToLayer("DropDoll");
    }
    public void Set(Rigidbody rigid)
    {
        var cols = rigid.GetComponentsInChildren<Collider>();
        for (int i = 0; i < cols.Length; i++)
            cols[i].gameObject.layer = m_DropDollLayer;
        var state = rigid.GetComponent<State>();
        state.m_Value = StateEnum.DropDoll;
        state.m_Dirty++;
    }
}