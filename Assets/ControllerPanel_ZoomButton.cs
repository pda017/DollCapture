using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ControllerPanel_ZoomButton : MonoBehaviour, IPointerDownHandler,IPointerExitHandler,IPointerUpHandler
{
    int m_NumState = 0;
    int[] m_TouchIdArr = new int[2];
    float m_StartDist;
    float m_Delta;
    bool m_bPush = false;
    public void OnPointerUp(PointerEventData eventData)
    {
        m_bPush = false;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        m_bPush = false;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        m_bPush = true;
    }
    void Update()
    {
        if (m_NumState == 0)
        {
            if (m_bPush)
            {
                if (Input.touchCount >= 2)
                {
                    CamZoomData.IsPush.m_Value = true;
                    CamZoomData.IsPush.m_Dirty++;
                    Touch t1 = Input.GetTouch(0);
                    Touch t2 = Input.GetTouch(1);
                    m_TouchIdArr[0] = t1.fingerId;
                    m_TouchIdArr[1] = t2.fingerId;
                    var t1Pos = ConvertToTargetResolution.Convert(t1.position);
                    var t2Pos = ConvertToTargetResolution.Convert(t2.position);
                    m_StartDist = Vector3.Distance(t1Pos, t2Pos);
                    m_NumState++;
                }
            }
        }
        else if (m_NumState == 1)
        {
            if (Input.touchCount < 2)
            {
                CamZoomData.IsPush.m_Value = false;
                CamZoomData.IsPush.m_Dirty++;
                m_Delta = 0;
                m_NumState = 0;
                return;
            }

            float curDist;
            if (GetDistByFingerId(out curDist))
            {
                m_Delta = curDist - m_StartDist;
                m_StartDist = curDist;
                CamZoomData.Delta.m_Value = m_Delta;
            }
        }
    }
    bool GetDistByFingerId(out float dist)
    {
        dist = 0;
        Touch t1, t2;
        if (GetTouchById.Get(m_TouchIdArr[0], out t1) && GetTouchById.Get(m_TouchIdArr[1], out t2))
        {
            var t1Pos = ConvertToTargetResolution.Convert(t1.position);
            var t2Pos = ConvertToTargetResolution.Convert(t2.position);
            dist = Vector3.Distance(t1Pos, t2Pos);
            return true;
        }
        return false;
    }
}
