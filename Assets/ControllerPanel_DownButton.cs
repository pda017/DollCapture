using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPanel_DownButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ButtonEvent.AddClickEvent(gameObject, () =>
        {
            ArcadeClawData.DownDirty.m_Value++;
        });
    }
}
