using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetryPanel_MainMenuButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ButtonEvent.AddClickEvent(gameObject, () =>
        {
            PanelMgr.HideCanvas("RetryPanel");
            PanelMgr.ShowCanvas("MainMenuPanel");
        });
    }
}
