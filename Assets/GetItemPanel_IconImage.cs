using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetItemPanel_IconImage : MonoBehaviour
{
    RawImage m_Image;
    GetItemListChanged m_ItemListChanged;
    // Start is called before the first frame update
    void Start()
    {
        m_Image = GetComponent<RawImage>();
        m_ItemListChanged = new GetItemListChanged();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_ItemListChanged.Check())
        {
            if (ArcadeCaseData.GetItemList.m_Value.Count != 0)
            {
                var itemKey = ArcadeCaseData.GetItemList.m_Value[0];
                var itemIcon = GetItemIcon.Get(itemKey);
                m_Image.texture = itemIcon.m_Tex;
            }
        }
    }
}
