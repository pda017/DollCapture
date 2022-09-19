using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public static class PanelMgr
{
    static List<Canvas> m_CanvasList = new List<Canvas>();
    public static Canvas ShowCanvas(string name,bool callUpdate = false)
    {
        var panel = Finder.Find<Canvas>(name);
        panel.enabled = true;
        if (callUpdate)
        {
            panel.BroadcastMessage("Update",SendMessageOptions.DontRequireReceiver);
        }
        return panel;
    }
    public static void RefreshPanel(string name)
    {
        Finder.FindObject(name).BroadcastMessage("Update", SendMessageOptions.DontRequireReceiver);
    }
    public static Canvas HideCanvas(string name)
    {
        var panel = Finder.Find<Canvas>(name);
        panel.enabled = false;
        return panel;
    }
    public static void HideCanvasAll(string[] name)
    {
        for (int i = 0; i < name.Length; i++)
        {
            var n = name[i];
            HideCanvas(n);
        }
    }
    public static void HideCanvasAll(List<string> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            var n = list[i];
            HideCanvas(n);
        }
    }
    public static void HideCanvasAll()
    {
        m_CanvasList.Clear();
        Finder.FindAll(m_CanvasList);
        m_CanvasList.ForEach(v => v.enabled = false);
    }
    public static void ShowCanvasAll()
    {
        m_CanvasList.Clear();
        Finder.FindAll(m_CanvasList);
        m_CanvasList.ForEach(v => v.enabled = true);
    }
}
