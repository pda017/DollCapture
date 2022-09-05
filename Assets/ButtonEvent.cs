using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class ButtonEvent
{
    Button m_Button;
    public ButtonEvent(GameObject owner)
    {
        m_Button = owner.GetComponent<Button>();
    }
    public void AddClickEvent(UnityAction onClick)
    {
        m_Button.onClick.AddListener(onClick);
    }
    public static void AddClickEvent(GameObject owner, UnityAction onClick)
    {
        owner.GetComponent<Button>().onClick.AddListener(onClick);
    }
}
