using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcadePanel_NodeButton : MonoBehaviour
{
    ZCanvasGroup m_CanvasGroup;
    Transform m_IndexTf;
    ArcadeInfo m_ArcadeInfo;
    // Start is called before the first frame update
    void Start()
    {
        m_CanvasGroup = new ZCanvasGroup(gameObject);
        m_IndexTf = GetComponentInParent<IndexTag>().transform;
        var index = m_IndexTf.GetSiblingIndex();
        m_ArcadeInfo = GetArcadeInfo.Get(index);
        if (m_ArcadeInfo == null)
        {
            m_CanvasGroup.SetActive(false);
        }
        ButtonEvent.AddClickEvent(gameObject, () =>
        {
            if (m_ArcadeInfo != null)
            {
                if (ArcadeCaseData.BuyList.m_Value.Contains(m_ArcadeInfo.m_Key))
                {
                    ArcadeCaseData.SelectedArcadeIndex.m_Value = index;
                }
                else
                {
                    if (InvenData.Token.m_Value >= m_ArcadeInfo.m_Cost)
                    {
                        InvenData.Token.m_Value -= m_ArcadeInfo.m_Cost;
                        ArcadeCaseData.BuyList.m_Value.Add(m_ArcadeInfo.m_Key);
                        ArcadeCaseData.BuyList.m_Dirty++;
                    }
                }
            }
        });
    }
}
