using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyCharParts
{
    public static void Apply(CharParts charParts, CharPartsEnum type, string key)
    {
        Apply(charParts.m_Value, type, key);
        charParts.m_Dirty++;
    }
    public static void Apply(CharPartsSetsInfo info, CharPartsEnum type, string key)
    {
        if (type == CharPartsEnum.Body)
        {
            info.m_Body = key;
            return;
        }
        else if (type == CharPartsEnum.Cloth)
        {
            info.m_Cloth = key;
            return;
        }
        else if (type == CharPartsEnum.Glass)
        {
            info.m_Glass = key;
            return;
        }
        else if (type == CharPartsEnum.Hair)
        {
            info.m_Hair = key;
            return;
        }
        else if (type == CharPartsEnum.Hat)
        {
            info.m_Hat = key;
            return;
        }
        else if (type == CharPartsEnum.Head)
        {
            info.m_Head = key;
            return;
        }
    }
}
