#if UNITY_EDITOR
using UnityEngine;
using System.Collections;
using UnityEditor;
public class DataScriptWizardMenu
{
    [MenuItem("Custom/CopyResourcesPath %&z")]
    public static void CopyResourcesPath()
    {
        var obj = Selection.activeObject;

        if (obj != null)
        {
            var id = Selection.assetGUIDs[0];
            var assetPath = AssetDatabase.GUIDToAssetPath(id);
            var index = assetPath.IndexOf("Resources") + "Resources".Length + 1;
            var fixPath = assetPath.Substring(index);
            int dotIndex = fixPath.LastIndexOf('.');
            fixPath = fixPath.Remove(dotIndex);
            GUIUtility.systemCopyBuffer = fixPath;
        }
    }
    [MenuItem("Custom/DataScriptWizardMenu %&x")]
    public static void DoData()
    {
        var obj = Selection.activeObject;
        
        if (obj != null)
        {
            var id = Selection.assetGUIDs[0];
            var assetPath = AssetDatabase.GUIDToAssetPath(id);
            var index = assetPath.IndexOf("Resources") + "Resources".Length + 1;
            var fixPath = assetPath.Substring(index);
            index = fixPath.LastIndexOf(".asset");
            fixPath = fixPath.Remove(index);
            Debug.Log(string.Format("Copy Data Script {0}", obj.name));
            string formatPath = GetTemplatePath("DataScriptWizard");
            var formatStr = System.IO.File.ReadAllText(formatPath);
            var script = string.Format(formatStr, obj.GetType().Name, obj.name, fixPath);
            GUIUtility.systemCopyBuffer = script;
        }
    }
    [MenuItem("Custom/DataDicScriptWizardMenu %&q")]
    public static void DoDataDic()
    {
        var obj = Selection.activeObject;

        if (obj != null)
        {
            var id = Selection.assetGUIDs[0];
            var assetPath = AssetDatabase.GUIDToAssetPath(id);
            var index = assetPath.IndexOf("Resources") + "Resources".Length + 1;
            var fixPath = assetPath.Substring(index);
            var data = Resources.LoadAll(fixPath);
            if (data.Length == 0)
                return;
            var type = data[0].GetType();
            string formatPath = GetTemplatePath("DataDicScriptWizard");
            var formatStr = System.IO.File.ReadAllText(formatPath);
            var script = string.Format(formatStr, type.Name, obj.name, fixPath);
            GUIUtility.systemCopyBuffer = script;
            Debug.Log(string.Format("Copy DataDic Script {0}", obj.name));
        }
    }
    [MenuItem("Custom/DataListScriptWizardMenu %&w")]
    public static void DoDataList()
    {
        var obj = Selection.activeObject;

        if (obj != null)
        {
            var id = Selection.assetGUIDs[0];
            var assetPath = AssetDatabase.GUIDToAssetPath(id);
            var index = assetPath.IndexOf("Resources") + "Resources".Length + 1;
            var fixPath = assetPath.Substring(index);
            var data = Resources.LoadAll(fixPath);
            if (data.Length == 0)
                return;
            var type = data[0].GetType();
            string formatPath = GetTemplatePath("DataListScriptWizard");
            var formatStr = System.IO.File.ReadAllText(formatPath);
            var script = string.Format(formatStr, type.Name, obj.name, fixPath);
            GUIUtility.systemCopyBuffer = script;
            Debug.Log(string.Format("Copy DataList Script {0}", obj.name));
        }
    }
    public static string GetTemplatePath(string name)
    {
        string[] guids = AssetDatabase.FindAssets(name, null);
        foreach (var g in guids)
        {
            var assetPath = AssetDatabase.GUIDToAssetPath(g);
            var dotIndex = assetPath.LastIndexOf('.');
            if (dotIndex != -1)
            {
                var ext = assetPath.Substring(dotIndex + 1);
                if (ext.ToLower().CompareTo("txt") == 0)
                    return assetPath;
            }
        }
        return string.Empty;
    }
}
#endif