using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionPanel_PageArrowButton : MonoBehaviour
{
    public int m_Dir;
    // Start is called before the first frame update
    void Start()
    {
        ButtonEvent.AddClickEvent(gameObject, () =>
        {
            var maxPage = GetCollectionPageNum.Get();
            var page = CollectionData.Page.m_Value;
            page += m_Dir;
            if (page < 0)
                page = maxPage - 1;
            if (page >= maxPage)
                page = 0;
            CollectionData.Page.m_Value = page;
        });
    }
}
