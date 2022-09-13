using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharPartsTypeToKey
{
    public static string Convert(CharPartsEnum type,CharParts charParts)
    {
        if (type == CharPartsEnum.Body)
            return charParts.m_Body;
        else if (type == CharPartsEnum.Cloth)
            return charParts.m_Cloth;
        else if (type == CharPartsEnum.Glass)
            return charParts.m_Glass;
        else if (type == CharPartsEnum.Hair)
            return charParts.m_Hair;
        else if (type == CharPartsEnum.Hat)
            return charParts.m_Hat;
        else if (type == CharPartsEnum.Head)
            return charParts.m_Head;
        else if (type == CharPartsEnum.Gun)
            return charParts.m_Gun;
        return string.Empty;
    }
}
