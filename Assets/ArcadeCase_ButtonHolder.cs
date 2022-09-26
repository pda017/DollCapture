using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcadeCase_ButtonHolder : MonoBehaviour
{
    ZAnimator m_Anim;
    CheckClawDown m_CheckClawDown;
    int m_NumState = 0;
    // Start is called before the first frame update
    void Start()
    {
        m_Anim = new ZAnimator(gameObject);
        m_CheckClawDown = new CheckClawDown();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_NumState == 0)
        {
            m_Anim.Play("Stop");
            m_CheckClawDown.Check();
            m_NumState++;
        }
        else if (m_NumState == 1)
        {
            if (m_CheckClawDown.Check())
            {
                m_Anim.Play("Play");
                m_NumState++;
            }
        }
        else if (m_NumState == 2)
        {
            if (m_CheckClawDown.Check())
            {
                m_Anim.Play("Play");
            }

            if (m_Anim.End())
            {
                m_NumState = 0;
            }
        }
    }
}
