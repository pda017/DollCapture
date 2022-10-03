using System.Collections;
using UnityEngine;

public class GetDollDropPos
{
    static Transform m_DropPos;
    public static Transform Get()
    {
        if (m_DropPos == null)
        {
            var arcadeObj = GameObject.FindGameObjectWithTag("Arcade");
            if (arcadeObj != null)
            {
                var dropPosTag = arcadeObj.GetComponentInChildren<DollDropPosTag>();
                if (dropPosTag != null)
                {
                    m_DropPos = dropPosTag.transform;
                }
            }
        }
        return m_DropPos;
    }
}