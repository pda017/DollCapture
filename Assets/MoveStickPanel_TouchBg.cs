using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoveStickPanel_TouchBg : MonoBehaviour
{
    int m_NumState = 0;
    Transform m_Tf;
    RectTransform m_Rt;

    // Start is called before the first frame update
    void Start()
    {
        m_Rt = transform as RectTransform;
        m_Tf = transform;
        MoveStickData.OriRtPos.m_Value = m_Rt.anchoredPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (m_NumState == 0)
        {
            if (MoveStickData.IsTouch.m_Value)
            {
                m_Tf.position = MoveStickData.StartPos.m_Value;
                m_NumState++;
            }
        }
        else if (m_NumState == 1)
        {
            if (!MoveStickData.IsTouch.m_Value)
            {
                m_Rt.anchoredPosition = MoveStickData.OriRtPos.m_Value;
                m_NumState = 0;
                return;
            }
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, MoveStickData.Radius.m_Value);
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, MoveStickData.InnerRadius.m_Value);
    }
}
