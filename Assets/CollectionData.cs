using System.Collections;
using UnityEngine;

public class CollectionData
{
    static Data_Int m_PageNodeNum;
    public static Data_Int PageNodeNum
    {
        get
        {
            if (m_PageNodeNum == null)
                m_PageNodeNum = Resources.Load<Data_Int>("Data/Collection/PageNodeNum");
            return m_PageNodeNum;
        }
    }
    static Data_Int m_Page;
    public static Data_Int Page
    {
        get
        {
            if (m_Page == null)
                m_Page = Resources.Load<Data_Int>("Data/Collection/Page");
            return m_Page;
        }
    }
    static Data_Int m_ItemIndex;
    public static Data_Int ItemIndex
    {
        get
        {
            if (m_ItemIndex == null)
                m_ItemIndex = Resources.Load<Data_Int>("Data/Collection/ItemIndex");
            return m_ItemIndex;
        }
    }
    static Data_Int m_SelectedCollection;
    public static Data_Int SelectedCollection
    {
        get
        {
            if (m_SelectedCollection == null)
                m_SelectedCollection = Resources.Load<Data_Int>("Data/Collection/SelectedCollection");
            return m_SelectedCollection;
        }
    }
    static Data_CollectionList m_CollectionList;
    public static Data_CollectionList CollectionList
    {
        get
        {
            if (m_CollectionList == null)
                m_CollectionList = Resources.Load<Data_CollectionList>("Data/Collection/CollectionList");
            return m_CollectionList;
        }
    }
}