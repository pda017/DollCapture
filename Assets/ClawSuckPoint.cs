using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawSuckPoint : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        DrawPosLine.Draw(transform.position, 0.25f, Color.red);
        DrawPosLine.Draw(transform.position + new Vector3(0, -ArcadeClawData.GrabCheckDist.m_Value), 0.1f, Color.red);

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position + new Vector3(0, -ArcadeClawData.DropCheckDist.m_Value), ArcadeClawData.DropCheckRadius.m_Value);
    }
}
