using System.Collections;
using UnityEngine;

public class XYToXZ
{
    public static Vector3 Convert(Vector3 value)
    {
        return new Vector3(value.x, 0, value.y);
    }
}