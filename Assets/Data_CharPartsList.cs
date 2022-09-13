using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Data/CharPartsList")]
public class Data_CharPartsList : ScriptableObject
{
    public List<CharPartsInfo> m_Value = new List<CharPartsInfo>();
    public float m_Dirty;
}

[System.Serializable]
public class CharPartsInfo
{
    public string m_Key;
    public CharPartsEnum m_Type;
    public string m_Prefab;
}