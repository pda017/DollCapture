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
        m_CharParts.m_Body = GetRandomKey(CharPartsEnum.Body);
        m_CharParts.m_Cloth = GetRandomKey(CharPartsEnum.Cloth);
        m_CharParts.m_Glass = GetRandomKey(CharPartsEnum.Glass);
        m_CharParts.m_Gun = GetRandomKey(CharPartsEnum.Gun);
        m_CharParts.m_Hair = GetRandomKey(CharPartsEnum.Hair);
        m_CharParts.m_Hat = GetRandomKey(CharPartsEnum.Hat);
        m_CharParts.m_Head = GetRandomKey(CharPartsEnum.Head);
        m_CharParts.m_Dirty++;
    }
    public string GetRandomKey(CharPartsEnum type)
    {
        var partsList = GetCharPartsInfoByType.Get(type);
        var parts = partsList[Random.Range(0, partsList.Count)];
        if (parts == null)
            return string.Empty;
        return parts.m_Key;
    }
}