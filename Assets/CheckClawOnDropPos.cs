using System.Collections;
using UnityEngine;

public class CheckClawOnDropPos
{
    public static void Start()
    {
        ArcadeClawData.ClawOnDropPosX.m_Value = false;
        ArcadeClawData.ClawOnDropPosZ.m_Value = false;
    }
    public static bool Check()
    {
        if (ArcadeClawData.ClawOnDropPosZ.m_Value
            && ArcadeClawData.ClawOnDropPosX.m_Value)
            return true;
        return false;
    }
}