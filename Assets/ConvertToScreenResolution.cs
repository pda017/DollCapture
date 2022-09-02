using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertToScreenResolution
{
    public static float Convert(float value)
    {
        float ratio = value / SystemData.TargetResolution.m_Value.y;
        return Screen.height * ratio;
    }
}
