#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
public class RefreshAllResourceMgrMenu
{
    [MenuItem("Custom/RefreshAllResourceMgrMenu %&r")]
    public static void Refresh()
    {
        var curScenePath = SceneManager.GetActiveScene().path;
        var scenes = EditorBuildSettings.scenes;
        foreach (var s in scenes)
        {
            EditorUtil.OpenScene(s.path);
            var objs = GameObject.FindObjectsOfType<GameObject>(true);
            foreach (var o in objs)
            {
                var resMgr = o.GetComponent<ILoadResourceFromPath>();
                if(resMgr != null)
                    resMgr.LoadResourceFromPath();
            }
        }
        EditorUtil.OpenScene(curScenePath);
    }
}
#endif