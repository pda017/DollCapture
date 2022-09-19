using System.Collections;
using UnityEngine;

public class CoinChanged
{
    int m_Dirty = int.MinValue;
    public bool Check()
    {
        if (m_Dirty != InvenData.Coin.m_Value)
        {
            m_Dirty = InvenData.Coin.m_Value;
            return true;
        }
        return false;
    }
}