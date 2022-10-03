using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvenData.Page.m_Value = 0;
        ArcadeCaseData.GetItemList.m_Value.Clear();
        PanelMgr.HideCanvasAll(PanelData.GameScene.m_Value);
        PanelMgr.ShowCanvas("MainMenuPanel");
        PanelMgr.ShowCanvas("MainUpperPanel");
    }
}
