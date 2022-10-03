using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcadePanel_BuyText : MonoBehaviour
{
    Transform m_IndexTf;
    ZText m_Text;
    // Start is called before the first frame update
    void Start()
    {
        m_Text = new ZText(gameObject);
        m_IndexTf = GetComponentInParent<IndexTag>().transform;
        var index = m_IndexTf.GetSiblingIndex();
        var arcadeInfo = GetArcadeInfo.Get(index);
        if (arcadeInfo != null)
            m_Text.SetText("{0}", arcadeInfo.m_Cost);
    }
}
