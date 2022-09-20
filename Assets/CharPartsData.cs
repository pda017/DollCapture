using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharPartsData
{
    static Data_String m_BaseCharPrefab;
    public static Data_String BaseCharPrefab
    {
        get
        {
            if (m_BaseCharPrefab == null)
                m_BaseCharPrefab = Resources.Load<Data_String>("Data/CharParts/BaseCharPrefab");
            return m_BaseCharPrefab;
        }
    }
    static Data_CharPartsList m_CharPartsList;
    public static Data_CharPartsList CharPartsList
    {
        get
        {
            if (m_CharPartsList == null)
                m_CharPartsList = Resources.Load<Data_CharPartsList>("Data/CharParts/CharPartsList");
            return m_CharPartsList;
        }
    }
}
