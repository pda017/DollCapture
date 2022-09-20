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
    public static Vector3 Convert(Vector3 value)
    {
        return new Vector3(Convert(value.x), Convert(value.y), Convert(value.z));
    }
}
