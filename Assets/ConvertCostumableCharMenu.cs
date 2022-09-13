#if UNITY_EDITOR
using System.Collections;
using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
public class ConvertCostumableCharMenu
{
    static List<Transform> m_List = new List<Transform>();
    [MenuItem("GameObject/Custom/ConvertCostumableChar", false, 10)]
    public static void DoSomething()
    {
        var selectedObjs = Selection.gameObjects;
        for (int i = 0; i < selectedObjs.Length; i++)
        {
            var selectedObj = selectedObjs[i];
            m_List.Clear();
            m_List.AddRange(selectedObj.GetComponentsInChildren<Transform>(true));
            var anim = selectedObj.GetComponentInChildren<Animator>();
            if (anim.gameObject.GetComponent<CharParts>() == null)
            {
                anim.gameObject.AddComponent<CharParts>();
                SetDirtyObj.Set(anim.gameObject);
            }
            ConvertObj("Char_Body_Parts", CharPartsEnum.Body);
            ConvertObj("Char_Cloth_Parts", CharPartsEnum.Cloth);
            ConvertObj("Char_Glass_Parts", CharPartsEnum.Glass);
            ConvertObj("Char_Hair_Parts", CharPartsEnum.Hair);
            ConvertObj("Char_Hat_Parts", CharPartsEnum.Hat);
            ConvertObj("Char_Head_Parts", CharPartsEnum.Head);
            ConvertObj("Char_Gun_Parts", CharPartsEnum.Gun);
        }
    }
    public static void ConvertObj(string objName,CharPartsEnum partsType)
    {
        var parts = m_List.Find(v => v.name.CompareTo(objName) == 0);
        if (parts != null)
            AddComponents(parts.gameObject, partsType);
    }
    public static void AddComponents(GameObject obj,CharPartsEnum partsType)
    {
        var charPartsType = obj.GetComponent<CharPartsType>();
        if (charPartsType == null)
        {
            charPartsType = obj.AddComponent<CharPartsType>();
            charPartsType.m_Value = partsType;
        }
        else
        {
            charPartsType.m_Value = partsType;
            charPartsType.m_Dirty++;
            SetDirtyObj.Set(charPartsType);
        }
        if (obj.GetComponent<UpdateCharParts>() == null)
            obj.AddComponent<UpdateCharParts>();
        SetDirtyObj.Set(obj);
    }
}
#endif