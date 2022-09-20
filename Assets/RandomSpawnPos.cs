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
    public Transform GetTf()
    {
        if (m_PosList.Count == 0)
        {
            var spawnBoundsObj = Finder.FindObject("SpawnBounds");
            var spawnBoundsTf = spawnBoundsObj.transform;
            for (int i = 0; i < spawnBoundsTf.childCount; i++)
            {
                m_PosList.Add(spawnBoundsTf.GetChild(i));
            }
            m_Index = m_PosList.Count;
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