using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetDirtyObj
{
    public static void Set(Object obj)
    {
#if UNITY_EDITOR
        UnityEditor.EditorUtility.SetDirty(obj);
#endif
    }
}
