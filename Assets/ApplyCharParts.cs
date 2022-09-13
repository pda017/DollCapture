using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyCharParts
{
    public static void Apply(CharParts charParts, CharPartsEnum type, string key)
    {
        if (type == CharPartsEnum.Body)
        {
            charParts.m_Body = key;
            charParts.m_Dirty++;
            return;
        }
        else if (type == CharPartsEnum.Cloth)
        {
            charParts.m_Cloth = key;
            charParts.m_Dirty++;
            return;
        }
        else if (type == CharPartsEnum.Glass)
        {
            charParts.m_Glass = key;
            charParts.m_Dirty++;
            return;
        }
        else if (type == CharPartsEnum.Hair)
        {
            charParts.m_Hair = key;
            charParts.m_Dirty++;
            return;
        }
        else if (type == CharPartsEnum.Hat)
        {
            charParts.m_Hat = key;
            charParts.m_Dirty++;
            return;
        }
        else if (type == CharPartsEnum.Head)
        {
            charParts.m_Head = key;
            charParts.m_Dirty++;
            return;
        }
    }
}
