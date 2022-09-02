#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class RefreshAndPlayMenu
{
    [MenuItem("Custom/RefreshAndPlayMenu &`")]
    public static void DoSomething()
    {
        AssetDatabase.Refresh();
        Debug.Log("Refresh Done");
        EditorUtil.PlayCurScene();
    }
}
#endif