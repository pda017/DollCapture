using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionPanel_CollectRateGauge : MonoBehaviour
{
    RectTransform m_Rt;
    float m_Width;
    ItemListChanged m_ItemListChagned;
    // Start is called before the first frame update
    void Start()
    {
        m_ItemListChagned = new ItemListChanged();
        m_Rt = transform as RectTransform;
        m_Width = m_Rt.sizeDelta.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (m_ItemListChagned.Check())
        {
            var size = m_Rt.sizeDelta;
            size.x = GetCollectRate.Get() * m_Width;
            m_Rt.sizeDelta = size;
        }
    }
}
