using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePanelButton : MonoBehaviour
{
    Canvas m_Canvas;
    // Start is called before the first frame update
    void Start()
    {
        m_Canvas = GetComponentInParent<Canvas>();
        ButtonEvent.AddClickEvent(gameObject, () =>
        {
            m_Canvas.enabled = false;
        });
    }
}
