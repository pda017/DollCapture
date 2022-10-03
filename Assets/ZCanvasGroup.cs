using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZCanvasGroup
{
    CanvasGroup m_CanvasGroup;
    public ZCanvasGroup(GameObject owner)
    {
        m_CanvasGroup = owner.GetComponent<CanvasGroup>();
    }
    public void SetActive(bool active)
    {
        if (active)
        {
            m_CanvasGroup.alpha = 1;
            m_CanvasGroup.blocksRaycasts = true;
            m_CanvasGroup.interactable = true;
        }
        else
        {
            m_CanvasGroup.alpha = 0;
            m_CanvasGroup.blocksRaycasts = false;
            m_CanvasGroup.interactable = false;
        }
    }
    public void SetAlpha(float alpha)
    {
        m_CanvasGroup.alpha = alpha;
    }
    public bool Show(float time)
    {
        m_CanvasGroup.alpha += Time.deltaTime / time;
        if (m_CanvasGroup.alpha >= 1f)
            return true;
        return false;
    }
    public bool Hide(float time)
    {
        m_CanvasGroup.alpha -= Time.deltaTime / time;
        if (m_CanvasGroup.alpha <= 0f)
            return true;
        return false;
    }
}
