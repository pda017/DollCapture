using System.Collections;
using UnityEngine;
using System.Collections.Generic;
public class SpawnRandomDoll
{
    static List<Vector3> m_PosList = new List<Vector3>();
    static List<Collider> m_BoundsList = new List<Collider>();
    static List<float> m_MassList = new List<float>();
    public static void Set(int num)
    {
        m_PosList.Clear();
        m_BoundsList.Clear();
        m_MassList.Clear();
        var spawnBoundsHolder = Finder.FindObject("SpawnBounds").transform;
        float fullMass = 0;
        for (int i = 0; i < spawnBoundsHolder.childCount; i++)
        {
            var child = spawnBoundsHolder.GetChild(i);
            var col = child.GetComponent<Collider>();
            m_BoundsList.Add(col);
            var bounds = col.bounds;
            var dist = Vector3.Distance(bounds.min, bounds.max);
            m_MassList.Add(dist);
            fullMass += dist;
        }

        for (int i = 0; i < m_BoundsList.Count; i++)
        {
            var col = m_BoundsList[i];
            var bounds = col.bounds;
            var mass = m_MassList[i];
            var ratio = mass / fullMass;
            var randNum = Mathf.RoundToInt(num * ratio);
            for (int k = 0; k < randNum; k++)
            {
                m_PosList.Add(RandomPosInBounds.Get(bounds));
            }
        }

        for (int i = 0; i < num; i++)
        {
            var pos = m_PosList[i];
            var obj = PrefabMgr.Create("RandomBaseChar");
            var tf = obj.transform;
            tf.position = pos;
            tf.rotation = Random.rotation;
        }
    }
}