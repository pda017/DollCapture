using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertToTargetResolution
{
    public static float Convert(float value)
    {
        float ratio = value / Screen.height;
        return SystemData.TargetResolution.m_Value.y * ratio;
    }
}
