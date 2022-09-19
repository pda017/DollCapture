using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinWarnPanel_ShopButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ButtonEvent.AddClickEvent(gameObject, () =>
        {
            PanelMgr.HideCanvas("CoinWarnPanel");
            PanelMgr.ShowCanvas("ShopPanel");
        });
    }
}
