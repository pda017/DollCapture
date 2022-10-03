using System.Collections;
using UnityEngine;
using System.Collections.Generic;
[CreateAssetMenu(menuName ="Data/DioramaRoomList")]
public class Data_DioramaRoomList : ScriptableObject
{
    public List<DioramaRoomInfo> m_Value = new List<DioramaRoomInfo>();
    public float m_Dirty;
}

[System.Serializable]
public class DioramaRoomInfo
{
    public bool m_Built;
    public List<DioramaObjInfo> m_ObjList = new List<DioramaObjInfo>();
    public int m_Cost;
}

[System.Serializable]
public class DioramaObjInfo
{
    public string m_Key;
    public string m_Prefab;
    public Vector3 m_Pos;
    public Vector3 m_Rot;
}