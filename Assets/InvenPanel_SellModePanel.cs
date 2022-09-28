using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvenPanel_SellModePanel : MonoBehaviour
{
    Canvas m_Canvas;
    // Start is called before the first frame update
    void Start()
    {
        m_Canvas = GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        if (InvenData.SellAllMode.m_Value)
            m_Canvas.enabled = true;
        else
            m_Canvas.enabled = false;
    }
}
