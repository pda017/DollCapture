using System.Collections;
using UnityEngine;
using System.Collections.Generic;
[CreateAssetMenu(menuName ="Data/CollectionList")]
public class Data_CollectionList : ScriptableObject
{
    public List<CollectionInfo> m_Value = new List<CollectionInfo>();
    public float m_Dirty;
}

[System.Serializable]
public class CollectionInfo
{
    public string m_Key;
    public List<string> m_ItemList = new List<string>();
}