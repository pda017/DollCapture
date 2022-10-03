#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class InitSaveMenu
{
    [MenuItem("Custom/InitSave")]
    public static void DoSomething()
    {
        InitSave.Set();
    }
}
#endif