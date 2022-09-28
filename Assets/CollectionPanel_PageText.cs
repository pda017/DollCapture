using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionPanel_PageText : MonoBehaviour
{
    ZText m_Text;
    CollectionPageChanged m_CollectionPageChanged;
    // Start is called before the first frame update
    void Start()
    {
        m_Text = new ZText(gameObject);
        m_CollectionPageChanged = new CollectionPageChanged();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_CollectionPageChanged.Check())
        {
            m_Text.SetText("{0}/{1}",CollectionData.Page.m_Value+1,GetCollectionPageNum.Get());
        }
    }
}
