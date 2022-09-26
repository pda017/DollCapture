using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doll_DropDoll : MonoBehaviour
{
    FSM m_FSM;
    GameObject m_Owner;
    Transform m_DropDollPos;
    Rigidbody m_Rigid;
    Transform m_Tf;
    ItemKey m_ItemKey;
    // Start is called before the first frame update
    void Start()
    {
        m_Owner = GetComponentInParent<Owner>().m_Value;
        m_FSM = new FSM(m_Owner);
        m_DropDollPos = Finder.FindObject("DollDropPos").transform;
        m_Rigid = m_Owner.GetComponent<Rigidbody>();
        m_Tf = m_Owner.transform;
        m_ItemKey = m_Owner.GetComponent<ItemKey>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_FSM.Begin(StateEnum.DropDoll))
        {
            if (m_FSM.BeginNumState(0))
            {
                var vel = m_Rigid.velocity;
                vel.x = 0;
                vel.z = 0;
                m_Rigid.velocity = vel;
                if (m_Tf.position.y < m_DropDollPos.position.y)
                {
                    var itemInfo = GetItemInfo.Get(m_ItemKey.m_Value);
                    itemInfo.m_IsCollected = true;
                    ItemData.ItemList.m_Dirty++;
                    InvenData.Inventory.m_Value.Add(m_ItemKey.m_Value);
                    InvenData.Inventory.m_Dirty++;
                    ArcadeCaseData.GetItemList.m_Value.Add(m_ItemKey.m_Value);
                    ArcadeCaseData.GetItemList.m_Dirty++;
                    Destroy(m_Owner);
                }
            }
        }
    }
}
