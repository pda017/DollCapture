using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcadePanel_SelectButton : MonoBehaviour
{
    ZCanvasGroup m_CanvasGroup;
    Transform m_IndexTf;
    ArcadeInfo m_ArcadeInfo;
    ArcadeSelectIndexChanged m_IndexChanged;
    ArcadeBuyListChanged m_BuyChanged;
    // Start is called before the first frame update
    void Start()
    {
        m_IndexChanged = new ArcadeSelectIndexChanged();
        m_BuyChanged = new ArcadeBuyListChanged();
        m_CanvasGroup = new ZCanvasGroup(gameObject);
        m_IndexTf = GetComponentInParent<IndexTag>().transform;
        var index = m_IndexTf.GetSiblingIndex();
        m_ArcadeInfo = GetArcadeInfo.Get(index);
    }

    // Update is called once per frame
    void Update()
    {
        if (m_ArcadeInfo != null)
        {
            if (m_IndexChanged.Check() || m_BuyChanged.Check())
            {
                if (ArcadeCaseData.BuyList.m_Value.Contains(m_ArcadeInfo.m_Key))
                    m_CanvasGroup.SetActive(true);
                else
                    m_CanvasGroup.SetActive(false);
            }
        }
    }
}
