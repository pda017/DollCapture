using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Data/FloatRange")]
public class Data_FloatRange : ScriptableObject
{
    public float m_Min;
    public float m_Max;
    public float m_Dirty;
}
