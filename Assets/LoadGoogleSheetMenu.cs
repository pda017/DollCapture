#if UNITY_EDITOR
using UnityEngine;
using System.Collections;
using UnityEditor;
public static class LoadGoogleSheetMenu
{
    [MenuItem("Custom/LoadGoogleSheet")]
    public static void Load()
    {
        LoadGoogleSheet.LoadAll();
    }
}
#endif