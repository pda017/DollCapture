using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectItemPanel_ArrowButton : MonoBehaviour
{
    public int m_Dir;
    // Start is called before the first frame update
    void Start()
    {
        ButtonEvent.AddClickEvent(gameObject, () =>
        {
            if (InvenData.Inventory.m_Value.Count != 0)
            {
                var index = DioramaData.ItemIndex.m_Value;
                index += m_Dir;
                
                if (index < 0)
                    index = InvenData.Inventory.m_Value.Count - 1;
                if (index >= InvenData.Inventory.m_Value.Count)
                    index = 0;
                DioramaData.ItemIndex.m_Value = index;
            }
        });
    }
}
