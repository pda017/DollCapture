using System.Collections;
using UnityEngine;
using System.Collections.Generic;
public class SpawnRandomDoll
{
    RandomSpawnPos m_RandomSpawnPos;
    public SpawnRandomDoll()
    {
        m_RandomSpawnPos = new RandomSpawnPos();
    }
    public void Set(int num)
    {
        for (int i = 0; i < num; i++)
        {
            var posTf = m_RandomSpawnPos.GetTf();
            var obj = PrefabMgr.Create("RandomBaseChar");
            var tf = obj.transform;
            tf.position = posTf.position;
            tf.rotation = posTf.rotation;
        }
    }
}