using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPanel_MainButton : MonoBehaviour
{
    GetClawLineState m_GetLineState;
    // Start is called before the first frame update
    void Start()
    {
        m_GetLineState = new GetClawLineState();
        ButtonEvent.AddClickEvent(gameObject, () =>
        {
            var state = m_GetLineState.Get();
            if (state != null && state.m_Value == StateEnum.Idle)
            {
                PanelMgr.HideCanvas("ControllerPanel");
                PanelMgr.HideCanvas("RetryPanel");
                PanelMgr.ShowCanvas("MainMenuPanel");
            }
        });
    }
}
