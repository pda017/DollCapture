using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabMgr : MonoBehaviour,ILoadResourceFromPath
{
    public string[] m_Path = null;
    public List<GameObject> m_List = new List<GameObject>();
    Dictionary<string, GameObject> m_Dic = new Dictionary<string, GameObject>();
    static PrefabMgr m_Inst;
    public static PrefabMgr GetInst()
    {
        if (m_Inst == null)
        {
            m_Inst = FindObjectOfType<PrefabMgr>();
        }
        return m_Inst;
    }
    [ContextMenu("LoadResourceFromPath")]
    public void LoadResourceFromPath()
    {
#if UNITY_EDITOR
        if (m_Path == null)
            return;
        m_List.Clear();
        var guids = UnityEditor.AssetDatabase.FindAssets("t:Prefab", m_Path);
        foreach (var guid in guids)
        {
            var assetPath = UnityEditor.AssetDatabase.GUIDToAssetPath(guid);
            var asset = UnityEditor.AssetDatabase.LoadAssetAtPath<GameObject>(assetPath);
            m_List.Add(asset);
        }
        SetDirtyObj.Set(this);
#endif
    }
    private void Awake()
    {
        m_List.ForEach(v =>
        {
            m_Dic.Add(v.name, v);
        });
    }
    public static GameObject Create(string prefabName)
    {
        GameObject obj = Instantiate(Get(prefabName));
        obj.name = prefabName;
        return obj;
    }
    public static GameObject Create(string prefabName, Vector3 pos)
    {
        GameObject obj = Instantiate(Get(prefabName),pos,Quaternion.identity);
        obj.name = prefabName;
        return obj;
    }
    public static GameObject Create(string prefabName, Vector3 pos,Quaternion rot)
    {
        GameObject obj = Instantiate(Get(prefabName), pos, rot);
        obj.name = prefabName;
        return obj;
    }
    public static GameObject Create(string prefabName, params object[] args)
    {
        return Create(string.Format(prefabName, args));
    }
    public static T Create<T>(string prefabName) where T : Component
    {
        GameObject obj = Create(prefabName);
        return obj.GetComponent<T>();
    }
    public static GameObject Get(string prefabName)
    {
        var inst = GetInst();
        GameObject value;
        inst.m_Dic.TryGetValue(prefabName, out value);
        return value;
    }
    public static GameObject Get(string prefabName, params object[] args)
    {
        return Get(string.Format(prefabName, args));
    }
    public static T Get<T>(string prefabName) where T : Component
    {
        return Get(prefabName).GetComponent<T>();
    }
}
