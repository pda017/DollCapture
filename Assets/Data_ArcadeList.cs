using System.Collections;
using UnityEngine;
using System.Collections.Generic;
[CreateAssetMenu(menuName ="Data/ArcadeList")]
public class Data_ArcadeList : ScriptableObject
{
    public List<ArcadeInfo> m_Value = new List<ArcadeInfo>();
    public float m_Dirty;
}

[System.Serializable]
public class ArcadeInfo
{
    public string m_Key;
    public string m_Name;
    public string m_Desc;
    public List<string> m_Item = new List<string>();
}