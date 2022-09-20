using System.Collections;
using UnityEngine;

public class PanelData
{
    static Data_StringList m_GameScene;
    public static Data_StringList GameScene
    {
        get
        {
            if (m_GameScene == null)
                m_GameScene = Resources.Load<Data_StringList>("Data/Panel/GameScene");
            return m_GameScene;
        }
    }
}