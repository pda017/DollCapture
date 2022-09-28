using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItemPanel_ItemName : MonoBehaviour
{
    ZText m_Text;
    GetItemListChanged m_ItemListChanged;
    // Start is called before the first frame update
    void Start()
    {
        m_Text = new ZText(gameObject);
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
                var itemInfo = GetItemInfo.Get(itemKey);
                m_Text.SetText(itemInfo.m_Name);
            }
        }
    }
}
