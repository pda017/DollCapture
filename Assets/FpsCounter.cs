using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsCounter : MonoBehaviour
{
    float m_Time = float.MinValue;
    int m_Fps;
    ZText m_Text;
    private void Awake()
    {
        m_Text = new ZText(gameObject);
        m_Time = Time.time;
    }
    void Update()
    {
        m_Fps++;
        if (Time.time - m_Time >= 1)
        {
            m_Time = Time.time;
            m_Text.SetText("{0}", m_Fps);
            m_Fps = 0;
        }
    }
}
