using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharPartsData
{
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
