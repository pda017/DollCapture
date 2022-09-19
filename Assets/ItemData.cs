using System.Collections;
using UnityEngine;

public class ItemData
{
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