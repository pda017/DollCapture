using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharPartsTypeToKey
{
    public static string Convert(CharPartsEnum type,CharParts charParts)
    {
        if (type == CharPartsEnum.Body)
            return charParts.m_Value.m_Body;
        else if (type == CharPartsEnum.Cloth)
            return charParts.m_Value.m_Cloth;
        else if (type == CharPartsEnum.Glass)
            return charParts.m_Value.m_Glass;
        else if (type == CharPartsEnum.Hair)
            return charParts.m_Value.m_Hair;
        else if (type == CharPartsEnum.Hat)
            return charParts.m_Value.m_Hat;
        else if (type == CharPartsEnum.Head)
            return charParts.m_Value.m_Head;
        else if (type == CharPartsEnum.Gun)
            return charParts.m_Value.m_Gun;
        return string.Empty;
    }
}
