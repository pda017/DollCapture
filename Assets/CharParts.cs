using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharParts : MonoBehaviour
{
    public CharPartsSetsInfo m_Value = new CharPartsSetsInfo();
    public float m_Dirty;
}

[System.Serializable]
public class CharPartsSetsInfo
{
    public string m_Body;
    public string m_Cloth;
    public string m_Glass;
    public string m_Hair;
    public string m_Hat;
    public string m_Head;
    public string m_Gun;
}
