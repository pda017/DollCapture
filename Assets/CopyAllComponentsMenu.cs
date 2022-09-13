#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class CopyAllComponentsMenu
{
    public static List<MonoBehaviour> m_ComponentList = new List<MonoBehaviour>();
    [MenuItem("GameObject/Custom/CopyAllComponents", false, 10)]
    public static void Copy()
    {
        m_ComponentList.Clear();
        m_ComponentList.AddRange(Selection.activeGameObject.GetComponents<MonoBehaviour>());
    }
    [MenuItem("GameObject/Custom/PasteAllComponentsAsNew", false, 10)]
    public static void PasteAsNew()
    {
        foreach (var targetObj in Selection.gameObjects)
        {
            m_ComponentList.ForEach(v =>
            {
                var type = v.GetType();
                var targetComp = targetObj.GetComponent(type);
                if (targetComp == null)
                {
                    UnityEditorInternal.ComponentUtility.CopyComponent(v);
                    UnityEditorInternal.ComponentUtility.PasteComponentAsNew(targetObj);
                }
            });
            SetDirtyObj.Set(targetObj);

        }
    }
    [MenuItem("GameObject/Custom/PasteAllComponentsAsValue", false, 10)]
    public static void PasteAsValue()
    {
        foreach (var targetObj in Selection.gameObjects)
        {
            m_ComponentList.ForEach(v =>
            {

                var type = v.GetType();
                var targetComp = targetObj.GetComponent(type);
                if (targetComp != null)
                {
                    UnityEditorInternal.ComponentUtility.CopyComponent(v);
                    UnityEditorInternal.ComponentUtility.PasteComponentValues(targetComp);
                    SetDirtyObj.Set(targetComp);
                }
            });
        }
    }
    [MenuItem("Assets/Custom/CopyAllComponents")]
    public static void CopyFromAsset()
    {
        Copy();
    }
    [MenuItem("Assets/Custom/PasteAllComponentsAsNew")]
    public static void PasteFromAssetAsNew()
    {
        PasteAsNew();
    }
    [MenuItem("Assets/Custom/PasteAllComponentsAsValue")]
    public static void PasteFromAssetAsValue()
    {
        PasteAsValue();
    }
}
#endif