using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : MonoBehaviour
{
    SpawnRandomDoll m_SpawnRandomDoll;
    // Start is called before the first frame update
    void Start()
    {
        m_SpawnRandomDoll = new SpawnRandomDoll();
        PanelMgr.HideCanvasAll(PanelData.GameScene.m_Value);
        PanelMgr.ShowCanvas("MainMenuPanel");
        PanelMgr.ShowCanvas("MainUpperPanel");

        ClearDolls.Set();
        m_SpawnRandomDoll.Set(10);
    }
}
