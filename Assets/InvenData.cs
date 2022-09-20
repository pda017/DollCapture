using System.Collections;
using UnityEngine;

public class InvenData
{
    static Data_Int m_Token;
    public static Data_Int Token
    {
        get
        {
            if (m_Token == null)
                m_Token = Resources.Load<Data_Int>("Data/Inven/Token");
            return m_Token;
        }
    }
    static Data_Int m_Coin;
    public static Data_Int Coin
    {
        get
        {
            if (m_Coin == null)
                m_Coin = Resources.Load<Data_Int>("Data/Inven/Coin");
            return m_Coin;
        }
    }
}