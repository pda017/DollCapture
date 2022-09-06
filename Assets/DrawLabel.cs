using System.Collections;
using UnityEngine;

public class DrawLabel
{
    static GUIStyle m_Style;
    public static void Draw(string text, Vector3 pos, Color color)
    {
#if UNITY_EDITOR
        if (m_Style == null)
            m_Style = new GUIStyle();

        m_Style.normal.textColor = color;
        UnityEditor.Handles.Label(pos, text, m_Style);

#endif
    }
}