using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectRoomPanel_SelectButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ButtonEvent.AddClickEvent(gameObject, () =>
        {
            PanelMgr.HideCanvas("SelectRoomPanel");
            PanelMgr.ShowCanvas("SelectItemPanel");
        });
    }
}
