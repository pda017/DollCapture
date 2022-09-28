using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Data/ItemList")]
public class Data_ItemList : ScriptableObject
{
    public List<ItemInfo> m_Value = new List<ItemInfo>();
    public float m_Dirty;
}

[System.Serializable]
public class ItemInfo
{
    public string m_Key;
    public string m_Name;
    public string m_Desc;
    public bool m_IsDoll;
    public string m_DollPrefab;
    public string m_IconPrefab;
    public int m_Cost;
    public string m_Pose;
    public CharPartsSetsInfo m_CharParts = new CharPartsSetsInfo();
    public bool m_IsCollected;
}