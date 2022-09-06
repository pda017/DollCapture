using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
public class FinderEditor : Editor
{
    [MenuItem("Custom/AddFinder &f")]
    public static void AddFinder()
    {
        Finder finder = Finder.GetInst();
        if (finder == null)
        {
            Debug.Log("Dont Exist Finder");
            return;
        }
        GameObject[] objs = Selection.gameObjects;
        foreach (GameObject o in objs)
        {
            finder.Add(o);
            Debug.Log("Add Finder:" + o.name);
        }
        finder.Refresh();
    }
}

#endif

public class Finder : MonoBehaviour
{
    public GameObject[] m_Objects;
    Dictionary<string, GameObject> m_Dic = new Dictionary<string, GameObject>();
    static Finder m_Inst;
    public static Finder GetInst()
    {
        if (m_Inst == null)
        {
            m_Inst = FindObjectOfType<Finder>();
        }
        return m_Inst;
    }
    public void AddDisabledObj()
    {
        var objs = Resources.FindObjectsOfTypeAll<AddToFinder>();
        for (int i = 0; i < objs.Length; i++)
        {
            if (!m_Dic.ContainsKey(objs[i].name))
                m_Dic.Add(objs[i].name, objs[i].gameObject);
        }
    }
    private void Awake()
    {
        foreach (GameObject o in m_Objects)
        {
            if(o != null && !m_Dic.ContainsKey(o.name))
                m_Dic.Add(o.name, o);
        }
        AddDisabledObj();
    }
    [ContextMenu("Refresh")]
    public void Refresh()
    {
        Dictionary<string, GameObject> dic = new Dictionary<string, GameObject>();
        foreach (GameObject o in m_Objects)
        {
            if (o == null)
                continue;
            if (dic.ContainsKey(o.name))
                continue;
            dic.Add(o.name, o);
        }
        m_Objects = new GameObject[dic.Count];
        dic.Values.CopyTo(m_Objects, 0);
#if UNITY_EDITOR
        EditorUtility.SetDirty(this);
#endif
    }
    public void Add(GameObject o)
    {
        if (m_Objects == null)
            m_Objects = new GameObject[0];
        List<GameObject> list = new List<GameObject>(m_Objects);
        list.Add(o);
        m_Objects = new GameObject[list.Count];
        list.CopyTo(m_Objects);
    }
    public static void AddToDic(GameObject obj)
    {
        if (!GetInst().m_Dic.ContainsKey(obj.name))
            GetInst().m_Dic.Add(obj.name, obj);
    }
    public static GameObject FindObject(string objName)
    {
        GameObject o;
        GetInst().m_Dic.TryGetValue(objName, out o);
        return o;
    }
    public static GameObject FindObject(string objName, params object[] args)
    {
        return FindObject(string.Format(objName, args));
    }
    public static T Find<T>(string objName) where T : Component
    {
        GameObject o = FindObject(objName);
        if (o != null)
            return o.GetComponent<T>();
        return null;
    }
    public static void Find<T>(ref T t, string objName) where T : Component
    {
        GameObject o = FindObject(objName);
        if (o != null)
            t = o.GetComponent<T>();
    }
    public static void FindAll<T>(List<T> list) where T : Component
    {
        var inst = GetInst();
        foreach (var pair in inst.m_Dic)
        {
            var value = pair.Value.GetComponent<T>();
            if (value != null)
                list.Add(value);
        }
    }
    public static GameObject SetActive(string objName, bool active)
    {
        GameObject obj = FindObject(objName);
        obj.SetActive(active);
        return obj;
    }
}
