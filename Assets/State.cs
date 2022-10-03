using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public enum StateEnum : byte
{
    Idle,
    Up,
    Down,
    Stop,
    Grab,
    DropDoll,
    ModifyItem,
}
public class State : MonoBehaviour
{
    public StateEnum m_Value;
    public float m_Dirty;
}
