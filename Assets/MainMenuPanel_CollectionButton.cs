using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuPanel_CollectionButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ButtonEvent.AddClickEvent(gameObject, () =>
        {
            PanelMgr.ShowCanvas("CollectionPanel");
        });
    }
}
