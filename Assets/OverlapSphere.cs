using System.Collections;
using UnityEngine;
using System.Collections.Generic;
public class OverlapSphere
{
    Collider[] m_HitArr = new Collider[10];
    List<Collider> m_HitList = new List<Collider>();
    public List<Collider> Check(Vector3 pos,float radius,int layer)
    {
        int hitCount = Physics.OverlapSphereNonAlloc(pos, radius, m_HitArr, layer);
        m_HitList.Clear();
        for (int i = 0; i < hitCount; i++)
            m_HitList.Add(m_HitArr[i]);
        return m_HitList;
    }
}