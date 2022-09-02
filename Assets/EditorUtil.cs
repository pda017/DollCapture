#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;

public static class EditorUtil
{
    public static EditorBuildSettingsScene[] GetAllBuildScene()
    {
        return EditorBuildSettings.scenes;
    }
    public static void DrawPath(Vector3 pos,Vector3[] points,Color color)
    {
        Vector3 prevPos = Vector3.zero;
        Handles.color = color;
        for (int i = 0; i < points.Length; i++)
        {
            if (i != 0)
                Handles.DrawLine(prevPos, points[i] + pos);
            prevPos = points[i] + pos;
        }
    }
    public static void SelectPath(string path)
    {
        UnityEngine.Object obj = AssetDatabase.LoadAssetAtPath<UnityEngine.Object>(path);

        Selection.activeObject = obj;

        EditorGUIUtility.PingObject(obj);
    }
    public static void GizmosDrawArrow(Vector3 from, Vector3 to,float tailLength = 0.1f)
    {
        var look = from - to;
        var dir = look.normalized;
        var tail1 = ((Quaternion.Euler(0, 0, 22.5f) * dir) * tailLength) + to;
        var tail2 = ((Quaternion.Euler(0, 0, -22.5f) * dir) * tailLength) + to;
        Gizmos.DrawLine(from, to);
        Gizmos.DrawLine(to, tail1);
        Gizmos.DrawLine(to, tail2);
        Gizmos.DrawLine(tail1, tail2);
    }
    public static void PlayCurScene()
    {
        var activeScene = EditorSceneManager.GetActiveScene();
        if (activeScene.isDirty)
            EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo();
        EditorApplication.isPlaying = true;
    }
    public static void PlayScene(string path)
    {
        if (EditorSceneManager.GetActiveScene().isDirty)
            EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo();
        EditorSceneManager.OpenScene(path);
        EditorApplication.isPlaying = true;
    }
    public static void OpenScene(string path,bool bForceSave = true)
    {
        if (bForceSave)
            EditorSceneManager.SaveOpenScenes();
        else
        {
            if (EditorSceneManager.GetActiveScene().isDirty)
                EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo();
        }
        EditorSceneManager.OpenScene(path);
    }
    public static bool HandlePoints(Vector3 pos, Vector3[] points,Object obj = null)
    {
        if (points == null)
            return false;
        bool bChange = false;
        for (int i = 0; i < points.Length; ++i)
        {
            using (var check = new EditorGUI.ChangeCheckScope())
            {
                var p = Handles.PositionHandle(points[i] + pos, Quaternion.identity);

                if (check.changed)
                {
                    if(obj != null)
                        Undo.RecordObject(obj, "ZPath Handle Point");
                    bChange = true;
                    points[i] = p - pos;
                }
            }
        }
        return bChange;
    }
}
#endif