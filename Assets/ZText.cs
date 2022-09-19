using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ZText
{
    TMP_Text m_Text;
    public ZText(GameObject owner)
    {
        m_Text = owner.GetComponent<TMP_Text>();
    }
    public ZText(TMP_Text text)
    {
        m_Text = text;
    }
    public static ZText CreateFromChild(GameObject owner)
    {
        return new ZText(owner.GetComponentInChildren<TMP_Text>());
    }
    public void SetFont(TMP_FontAsset font)
    {
        m_Text.font = font;
    }
    public void SetText(string format, params object[] args)
    {
        m_Text.text = string.Format(format, args);
    }
    public void SetText(string text)
    {
        m_Text.text = text;
    }
    public string GetText()
    {
        return m_Text.text;
    }
    public void SetEnable(bool bEnable)
    {
        m_Text.enabled = bEnable;
    }
    public void SetColor(Color color)
    {
        m_Text.color = color;
    }
    public void SetSortingOrder(int order)
    {
        var tmp = (TextMeshPro)m_Text;
        tmp.sortingOrder = order;
    }
}
