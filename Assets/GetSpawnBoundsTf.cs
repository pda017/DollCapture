using System.Collections;
using UnityEngine;

public class GetSpawnBoundsTf
{
    static Transform m_Tf;
    public static Transform Get()
    {
        if (m_Tf == null)
        {
            var obj = GameObject.FindWithTag("Arcade");
            if (obj != null)
            {
                var spawnBoundsTag = obj.GetComponentInChildren<SpawnBoundsTag>();
                if (spawnBoundsTag != null)
                    m_Tf = spawnBoundsTag.transform;
            }
        }
        return m_Tf;
    }
}