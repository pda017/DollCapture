using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcadeCase_Line : MonoBehaviour
{
    public float m_MoveSpeed = 1;
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
        var upPos = m_OriPos + new Vector3(0, m_Length);
        var lookY = upPos.y - m_Tf.position.y;
        var dir = Mathf.Sign(lookY);
        var dist = Mathf.Abs(lookY);
        var moveAmount = m_MoveSpeed * Time.deltaTime;
        if (moveAmount > dist)
        {
            m_Tf.Translate(0, dir * dist, 0, Space.World);
            return true;
        }
        else
        {
            m_Tf.Translate(0, dir * moveAmount, 0, Space.World);
            return false;
        }
    }
    public void Down()
    {
        m_Tf.position += Vector3.down * Time.deltaTime * m_MoveSpeed;
    }
    private void OnDrawGizmos()
    {
        DrawPosLine.Draw(transform.position - new Vector3(0, m_LineStart), 0.25f, Color.red);
        DrawPosLine.Draw(transform.position - new Vector3(0, m_LineStart + m_Length), 0.25f,Color.red);
    }
}
