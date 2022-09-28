using System.Collections;
using UnityEngine;

public class AllItemCountInCollection
{
    static bool m_First = true;
    static int m_Count = 0;
    public static int Get()
    {
        if (m_First)
        {
            m_First = false;
            m_Count = 0;
            CollectionData.CollectionList.m_Value.ForEach(v =>
            {
                m_Count += v.m_ItemList.Count;
            });
        }
        return m_Count;
    }
}