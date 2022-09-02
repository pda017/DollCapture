using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcadeCase_Line : MonoBehaviour
{
    public float m_LineStart;
    public float m_Length;
    Transform m_Tf;
    Vector3 m_OriPos;
    // Start is called before the first frame update
    void Start()
    {
        m_Tf = transform;
        m_OriPos = m_Tf.position;
        InitPos();
    }
    public void InitPos()
    {
        m_Tf.position = m_OriPos + new Vector3(0, m_Length);
    }
    public bool Up()
    {
        return false;
    }
    public void Down()
    {
    }
    private void OnDrawGizmos()
    {
        DrawPosLine.Draw(transform.position - new Vector3(0, m_LineStart), 0.25f, Color.red);
        DrawPosLine.Draw(transform.position - new Vector3(0, m_LineStart + m_Length), 0.25f,Color.red);
    }
}
