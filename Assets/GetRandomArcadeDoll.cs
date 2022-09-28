using System.Collections;
using UnityEngine;
using System.Collections.Generic;
public class GetRandomArcadeDoll
{
    List<string> m_ItemList = new List<string>();
    int m_Index = 0;
    ArcadeInfo m_ArcadeInfo;
    public void SetArcade(string key)
    {
        m_ArcadeInfo = GetArcadeInfo.Get(key);
        m_Index = 0;
        m_ItemList.Clear();
        m_ItemList.AddRange(m_ArcadeInfo.m_Item);
        Shuffle.ShuffleList(m_ItemList);
    }
    public ItemInfo GetShuffled()
    {
        if (m_Index >= m_ItemList.Count)
        {
            m_Index = 0;
            Shuffle.ShuffleList(m_ItemList);
        }

        var key = m_ItemList[m_Index];
        var itemInfo = GetItemInfo.Get(key);
        return itemInfo;
    }
    public ItemInfo Get()
    {
        var key = m_ItemList[Random.Range(0, m_ItemList.Count)];
        var itemInfo = GetItemInfo.Get(key);
        return itemInfo;
    }
}