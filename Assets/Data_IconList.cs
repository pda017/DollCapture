using System.Collections;
using UnityEngine;
using System.Collections.Generic;
[CreateAssetMenu(menuName ="Data/IconList")]
public class Data_IconList : ScriptableObject
{
    public List<IconInfo> m_Value = new List<IconInfo>();
    public float m_Dirty;
}

[System.Serializable]
public class IconInfo
{
    public string m_Key;
    public Texture2D m_Tex;
}