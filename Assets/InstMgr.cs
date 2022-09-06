using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstMgr : MonoBehaviour
{
    Dictionary<int, GameObject> m_Dic = new Dictionary<int, GameObject>();
    static InstMgr m_Inst;
    public static InstMgr GetInst()
    {
        if (m_Inst == null)
        {
            m_Inst = FindObjectOfType<InstMgr>();
        }
        return m_Inst;
    }
    public static GameObject Get(int instId)
    {
        var inst = GetInst();
        GameObject value;
        inst.m_Dic.TryGetValue(instId, out value);
        return value;
    }
    public static void Add(GameObject obj)
    {
        GetInst().m_Dic.Add(obj.GetInstanceID(), obj);
    }

    public static void Remove(GameObject obj)
    {
        var inst = GetInst();
        if (inst == null)
            return;
        inst.m_Dic.Remove(obj.GetInstanceID());
    }
}
