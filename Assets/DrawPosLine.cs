using System.Collections;
using UnityEngine;

public class DrawPosLine
{
    public static void Draw(Vector3 pos,float radius,Color color)
    {
        Gizmos.color = color;
        Gizmos.DrawLine(pos + (Vector3.left * radius), pos + (Vector3.right * radius));
        Gizmos.DrawLine(pos + (Vector3.down * radius), pos + (Vector3.up * radius));
        Gizmos.DrawLine(pos + (Vector3.back * radius), pos + (Vector3.forward * radius));
    }
}