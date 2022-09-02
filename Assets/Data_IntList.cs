using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Data/IntList")]
public class Data_IntList : ScriptableObject
{
    public List<int> m_Value = new List<int>();
    public float m_Dirty;
}
