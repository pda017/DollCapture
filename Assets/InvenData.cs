using System.Collections;
using UnityEngine;

public class InvenData
{
    static Data_IntList m_SellList;
    public static Data_IntList SellList
    {
        get
        {
            if (m_SellList == null)
                m_SellList = Resources.Load<Data_IntList>("Data/Inven/SellList");
            return m_SellList;
        }
    }
    static Data_Bool m_SellAllMode;
    public static Data_Bool SellAllMode
    {
        get
        {
            if (m_SellAllMode == null)
                m_SellAllMode = Resources.Load<Data_Bool>("Data/Inven/SellAllMode");
            return m_SellAllMode;
        }
    }
    static Data_Int m_PageNodeNum;
    public static Data_Int PageNodeNum
    {
        get
        {
            if (m_PageNodeNum == null)
                m_PageNodeNum = Resources.Load<Data_Int>("Data/Inven/PageNodeNum");
            return m_PageNodeNum;
        }
    }
    static Data_Int m_Page;
    public static Data_Int Page
    {
        get
        {
            if (m_Page == null)
                m_Page = Resources.Load<Data_Int>("Data/Inven/Page");
            return m_Page;
        }
    }
    static Data_Int m_SelectIndex;
    public static Data_Int SelectIndex
    {
        get
        {
            if (m_SelectIndex == null)
                m_SelectIndex = Resources.Load<Data_Int>("Data/Inven/SelectIndex");
            return m_SelectIndex;
        }
    }
    static Data_StringList m_Inventory;
    public static Data_StringList Inventory
    {
        get
        {
            if (m_Inventory == null)
                m_Inventory = Resources.Load<Data_StringList>("Data/Inven/Inventory");
            return m_Inventory;
        }
    }
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