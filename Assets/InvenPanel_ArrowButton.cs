using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvenPanel_ArrowButton : MonoBehaviour
{
    public int m_Value;
    // Start is called before the first frame update
    void Start()
    {
        ButtonEvent.AddClickEvent(gameObject, () =>
        {
            var maxPage = GetInvenPageNum.Get();
            var page = InvenData.Page;
            page.m_Value += m_Value;
            if (page.m_Value < 0)
                page.m_Value = maxPage - 1;
            if (page.m_Value >= maxPage)
                page.m_Value = 0;
        });
    }
}
