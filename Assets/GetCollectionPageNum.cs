using System.Collections;
using UnityEngine;

public class GetCollectionPageNum
{
    public static int Get()
    {
        return GetPageNum.Get(CollectionData.CollectionList.m_Value.Count, CollectionData.PageNodeNum.m_Value);
    }
}