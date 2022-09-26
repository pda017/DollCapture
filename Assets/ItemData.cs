using System.Collections;
using UnityEngine;

public class ItemData
{
    static Data_IconList m_IconList;
    public static Data_IconList IconList
    {
        get
        {
            if (m_IconList == null)
                m_IconList = Resources.Load<Data_IconList>("Data/Item/IconList");
            return m_IconList;
        }
    }
    static Data_ItemList m_ItemList;
    public static Data_ItemList ItemList
    {
        get
        {
            if (m_ItemList == null)
                m_ItemList = Resources.Load<Data_ItemList>("Data/Item/ItemList");
            return m_ItemList;
        }
    }
}