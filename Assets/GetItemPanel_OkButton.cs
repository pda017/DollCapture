using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItemPanel_OkButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ButtonEvent.AddClickEvent(gameObject, () =>
        {
            if (ArcadeCaseData.GetItemList.m_Value.Count == 0)
            {
                PanelMgr.HideCanvas("GetItemPanel");
            }
            else
            {
                ArcadeCaseData.GetItemList.m_Value.RemoveAt(0);
                ArcadeCaseData.GetItemList.m_Dirty++;

                if(ArcadeCaseData.GetItemList.m_Value.Count == 0)
                    PanelMgr.HideCanvas("GetItemPanel");
            }
        });
    }
}
