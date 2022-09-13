using System.Collections;
using UnityEngine;

public class SetRandomPose
{
    static int m_PoseIndex;
    CharPose m_CharPose;
    public SetRandomPose(GameObject owner)
    {
        m_CharPose = owner.GetComponent<CharPose>();
    }
    public void SetSequence()
    {
        if (m_PoseIndex >= CharPoseData.PoseList.m_Value.Count)
            m_PoseIndex = 0;
        m_CharPose.m_Value = CharPoseData.PoseList.m_Value[m_PoseIndex];
        m_CharPose.m_Dirty++;
        m_PoseIndex++;
    }
    public void Set()
    {
        m_CharPose.m_Value = CharPoseData.PoseList.m_Value[Random.Range(0,CharPoseData.PoseList.m_Value.Count)];
        m_CharPose.m_Dirty++;
    }
}