using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuPanel_StartButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ButtonEvent.AddClickEvent(gameObject, () =>
        {
            if (InvenData.Coin.m_Value > 0)
            {
                InvenData.Coin.m_Value--;
                PanelMgr.HideCanvas("MainMenuPanel");
                PanelMgr.ShowCanvas("ControllerPanel");
            }
            else
            {
                PanelMgr.ShowCanvas("CoinWarnPanel");
            }
        });
    }
}
