using System.Collections;
using UnityEngine;

public class MoveStickDirToCamDir
{
    public static Vector3 Get()
    {
        var stickDir = MoveStickData.DirXZ.m_Value;
        var camTf = GetMainCam.GetTf();
        var forward = camTf.forward;
        forward.y = 0;
        forward.Normalize();
        var right = camTf.right;

        var camDir = Vector3.zero;
        camDir += stickDir.x * right;
        camDir += stickDir.z * forward;
        return camDir;
    }
}