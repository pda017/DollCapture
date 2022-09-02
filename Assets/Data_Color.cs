using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Data/Color")]
public class Data_Color : ScriptableObject
{
    public Color m_Value = Color.white;
    public float m_Dirty;
}
