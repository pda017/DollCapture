using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ControllerPanel_RotateButton : MonoBehaviour,IPointerDownHandler,IPointerUpHandler,IPointerExitHandler
{
    Vector3 m_StartPos;
    Vector3 m_CurPos;
    Vector3 m_Dt;
    public void OnPointerDown(PointerEventData eventData)
    {
        if (Input.touchCount >= 2)
        {
            CamRotateData.IsPush.m_Value = false;
            CamRotateData.IsPush.m_Dirty++;
            return;
        }
        CamRotateData.IsPush.m_Value = true;
        CamRotateData.IsPush.m_Dirty++;
        m_StartPos = ConvertToTargetResolution.Convert(eventData.position);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        CamRotateData.IsPush.m_Value = false;
        CamRotateData.IsPush.m_Dirty++;
    }
    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        CamRotateData.IsPush.m_Value = false;
        CamRotateData.IsPush.m_Dirty++;
    }
    void Update()
    {
        if (Input.touchCount >= 2)
        {
            CamRotateData.IsPush.m_Value = false;
            CamRotateData.IsPush.m_Dirty++;
            return;
        }
        if (CamRotateData.IsPush.m_Value)
        {
            m_CurPos = ConvertToTargetResolution.Convert(Input.mousePosition);
            m_Dt = m_CurPos - m_StartPos;
            m_StartPos = m_CurPos;

            CamRotateData.MoveDelta.m_Value = m_Dt;
            CamRotateData.MoveDelta.m_Dirty++;
        }
    }
}
