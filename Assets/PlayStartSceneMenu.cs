#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class PlayStartSceneMenu
{
    [MenuItem("Custom/PlayStartScene &1")]
    public static void DoSomething()
    {
        AssetDatabase.Refresh();
        EditorUtil.PlayScene("Assets/Scenes/LoadIcon.unity");
    }
}
#endif