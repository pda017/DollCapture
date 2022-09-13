using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Data/StringList")]
public class Data_StringList : ScriptableObject
{
    public List<string> m_Value = new List<string>();
    public float m_Dirty;
}
