using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharPartsMgr : MonoBehaviour
{
    static string m_CharPrefab = "BaseChar";
    Dictionary<string, GameObject> m_Dic = new Dictionary<string, GameObject>();
    static CharPartsMgr m_Inst;
    public static CharPartsMgr GetInst()
    {
        if (m_Inst == null)
            m_Inst = FindObjectOfType<CharPartsMgr>();
        return m_Inst;
    }
    // Start is called before the first frame update
    void Start()
    {
        var baseObj = PrefabMgr.Get(m_CharPrefab);
        var partsTypes = baseObj.GetComponentsInChildren<CharPartsType>();
        foreach (var partsType in partsTypes)
        {
            var typeTf = partsType.transform;
            for (int i = 0; i < typeTf.childCount; i++)
            {
                var child = typeTf.GetChild(i);
                m_Dic.Add(child.name, child.gameObject);
            }
        }
    }

    public static GameObject Get(string key)
    {
        GameObject value;
        GetInst().m_Dic.TryGetValue(key, out value);
        return value;
    }
    public static GameObject Create(string key)
    {
        var prefab = Get(key);
        if (prefab == null)
            return null;
        var instObj = Instantiate(prefab);
        instObj.name = prefab.name;
        return instObj;
    }
}
