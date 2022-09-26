using System.Collections;
using UnityEngine;

public class CharPartsCopy
{
    public static void Set(CharPartsSetsInfo origin, CharPartsSetsInfo target)
    {
        target.m_Body = origin.m_Body;
        target.m_Cloth = origin.m_Cloth;
        target.m_Glass = origin.m_Glass;
        target.m_Gun = origin.m_Gun;
        target.m_Hair = origin.m_Hair;
        target.m_Hat = origin.m_Hat;
        target.m_Head = origin.m_Head;
    }
}