using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDollTest_RandomButton : MonoBehaviour
{
    GameObject m_EmptyCharObj;
    CharParts m_CharParts;
    CharPose m_CharPose;
    int m_PoseIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        m_EmptyCharObj = Finder.FindObject("EmptyChar");
        m_CharParts = m_EmptyCharObj.GetComponent<CharParts>();
        m_CharPose = m_EmptyCharObj.GetComponent<CharPose>();
        ButtonEvent.AddClickEvent(gameObject, () =>
        {
            m_CharParts.m_Value.m_Body = GetRandomKey(CharPartsEnum.Body);
            m_CharParts.m_Value.m_Cloth = GetRandomKey(CharPartsEnum.Cloth);
            m_CharParts.m_Value.m_Glass = GetRandomKey(CharPartsEnum.Glass);
            m_CharParts.m_Value.m_Gun = GetRandomKey(CharPartsEnum.Gun);
            m_CharParts.m_Value.m_Hair = GetRandomKey(CharPartsEnum.Hair);
            m_CharParts.m_Value.m_Hat = GetRandomKey(CharPartsEnum.Hat);
            m_CharParts.m_Value.m_Head = GetRandomKey(CharPartsEnum.Head);
            m_CharParts.m_Dirty++;
            if (m_PoseIndex >= CharPoseData.PoseList.m_Value.Count)
                m_PoseIndex = 0;
            m_CharPose.m_Value = CharPoseData.PoseList.m_Value[m_PoseIndex];
            m_CharPose.m_Dirty++;
            m_PoseIndex++;
        });
    }
    string GetRandomKey(CharPartsEnum type)
    {
        var partsList = GetCharPartsInfoByType.Get(type);
        var parts = partsList[Random.Range(0, partsList.Count)];
        if (parts == null)
            return string.Empty;
        return parts.m_Key;
    }
}
