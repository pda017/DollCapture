using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMenuButton : MonoBehaviour
{
    public string m_PanelName;
    // Start is called before the first frame update
    void Start()
    {
        ButtonEvent.AddClickEvent(gameObject, () =>
        {
            PanelMgr.HideCanvasAll(ArcadeCaseData.PanelList.m_Value);
            PanelMgr.ShowCanvas(m_PanelName);
        });
    }
}
