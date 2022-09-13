using System.Collections;
using UnityEngine;

public class CharPoseData
{
    static Data_StringList m_PoseList;
    public static Data_StringList PoseList
    {
        get
        {
            if (m_PoseList == null)
                m_PoseList = Resources.Load<Data_StringList>("Data/CharPose/PoseList");
            return m_PoseList;
        }
    }
}