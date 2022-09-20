using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PanelMgr.HideCanvasAll(PanelData.GameScene.m_Value);
        PanelMgr.ShowCanvas("MainMenuPanel");
        PanelMgr.ShowCanvas("MainUpperPanel");

        ClearDolls.Set();
        SpawnRandomDoll.Set(20);
    }
}
