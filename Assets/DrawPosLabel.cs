using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawPosLabel : MonoBehaviour
{
    public float m_Radius = 0.1f;
    private void OnDrawGizmos()
    {
        DrawPosLine.Draw(transform.position, m_Radius, Color.red);
        DrawLabel.Draw(gameObject.name, transform.position, Color.red);
    }
}
