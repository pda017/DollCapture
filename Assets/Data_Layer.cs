using UnityEngine;
using System.Collections;

[CreateAssetMenu(menuName ="Data/Layer")]
public class Data_Layer : ScriptableObject
{
    public LayerMask m_Value;
    public float m_Dirty;
}
