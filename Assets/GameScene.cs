using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : MonoBehaviour
{
    SpawnArcadeDoll m_SpawnArcadeDoll;
    // Start is called before the first frame update
    void Start()
    {
        InvenData.Page.m_Value = 0;
        ArcadeCaseData.GetItemList.m_Value.Clear();
        m_SpawnArcadeDoll = new SpawnArcadeDoll();
        PanelMgr.HideCanvasAll(PanelData.GameScene.m_Value);
        PanelMgr.ShowCanvas("MainMenuPanel");
        PanelMgr.ShowCanvas("MainUpperPanel");

        ClearDolls.Set();
        m_SpawnArcadeDoll.Set(8);
    }
}
