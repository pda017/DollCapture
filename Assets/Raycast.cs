using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast
{
    RaycastHit[] m_HitArr = new RaycastHit[10];
    public List<RaycastHit> m_HitList = new List<RaycastHit>();
    public bool Check(Vector3 origin,Vector3 dir,float dist,int layer, bool bSort = true)
    {
        var hitCount = Physics.RaycastNonAlloc(origin, dir, m_HitArr, dist, layer);
        if (hitCount != 0)
        {
            m_HitList.Clear();
            for (int i = 0; i < hitCount; i++)
            {
                m_HitList.Add(m_HitArr[i]);
            }
            if (bSort)
                Sort();
            return true;
        }
        return false;
    }
    public bool Check(Ray ray, float dist, int layer, bool bSort = true)
    {
        return Check(ray.origin, ray.direction, dist, layer,bSort);
    }
    public bool CheckMouse(float dist, int layer,bool bSort = true,Camera cam = null)
    {
        if (cam == null)
            cam = GetMainCam.Get();
        var ray = cam.ScreenPointToRay(Input.mousePosition);
        return Check(ray, dist, layer,bSort);
    }
    public void Sort()
    {
        m_HitList.Sort((a, b) => a.distance.CompareTo(b.distance));
    }
}