using System.Collections;
using UnityEngine;
using System.Collections.Generic;
public class RandomSpawnPos
{
    List<Transform> m_PosList = new List<Transform>();
    int m_Index = 0;
    public Vector3 Get()
    {
        var pos = GetTf();
        return pos.position;
    }
    public void Init()
    {
        m_PosList.Clear();
        var spawnBoundsTf = GetSpawnBoundsTf.Get();
        for (int i = 0; i < spawnBoundsTf.childCount; i++)
        {
            m_PosList.Add(spawnBoundsTf.GetChild(i));
        }
        m_Index = m_PosList.Count;
    }
    public Transform GetTf()
    {
        if (m_PosList.Count == 0)
        {
            Init();
        }

        if (m_Index >= m_PosList.Count)
        {
            m_Index = 0;
            Shuffle.ShuffleList(m_PosList);
        }

        var pos = m_PosList[m_Index];
        m_Index++;
        return pos;
    }
}