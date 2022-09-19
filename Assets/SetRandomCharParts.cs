using System.Collections;
using UnityEngine;

public class SetRandomCharParts
{
    CharParts m_CharParts;
    public SetRandomCharParts(GameObject owner)
    {
        m_CharParts = owner.GetComponent<CharParts>();
    }
    public void Set()
    {
        Set(m_CharParts);
    }
    public static void Set(CharParts charParts)
    {
        charParts.m_Value.m_Body = GetRandomKey(CharPartsEnum.Body);
        charParts.m_Value.m_Cloth = GetRandomKey(CharPartsEnum.Cloth);
        charParts.m_Value.m_Glass = GetRandomKey(CharPartsEnum.Glass);
        charParts.m_Value.m_Gun = GetRandomKey(CharPartsEnum.Gun);
        charParts.m_Value.m_Hair = GetRandomKey(CharPartsEnum.Hair);
        charParts.m_Value.m_Hat = GetRandomKey(CharPartsEnum.Hat);
        charParts.m_Value.m_Head = GetRandomKey(CharPartsEnum.Head);
        charParts.m_Dirty++;
    }
    public static string GetRandomKey(CharPartsEnum type)
    {
        var partsList = GetCharPartsInfoByType.Get(type);
        var parts = partsList[Random.Range(0, partsList.Count)];
        if (parts == null)
            return string.Empty;
        return parts.m_Key;
    }
}