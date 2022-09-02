using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class MoveStickPanel_TouchButton : MonoBehaviour,IPointerDownHandler,IPointerMoveHandler,IPointerUpHandler,IPointerExitHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        MoveStickData.IsTouch.m_Value = true;
        MoveStickData.IsTouch.m_Dirty++;
        MoveStickData.StartPos.m_Value = eventData.position;
        MoveStickData.StartPos.m_Dirty++;
        MoveStickData.EndPos.m_Value = eventData.position;
        MoveStickData.EndPos.m_Dirty++;
        MoveStickData.ClampedEndPos.m_Value = eventData.position;
        MoveStickData.ClampedEndPos.m_Dirty++;
        MoveStickData.MoveSpeedRate.m_Value = 0;
        MoveStickData.Dist.m_Value = 0;
        MoveStickData.MoveSpeedRate.m_Value = 0;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        OnPointerUp(eventData);
    }

    public void OnPointerMove(PointerEventData eventData)
    {
        if (MoveStickData.IsTouch.m_Value)
        {
            MoveStickData.EndPos.m_Value = eventData.position;
            MoveStickData.EndPos.m_Dirty++;

            var radius = MoveStickData.Radius.m_Value - MoveStickData.InnerRadius.m_Value;

            var look = MoveStickData.EndPos.m_Value - MoveStickData.StartPos.m_Value;
            look.z = 0;
            MoveStickData.Dir.m_Value = look.normalized;
            MoveStickData.Dir.m_Dirty++;
            MoveStickData.DirXZ.m_Value = XYToXZ.Convert(MoveStickData.Dir.m_Value);
            MoveStickData.DirXZ.m_Dirty++;
            MoveStickData.Dist.m_Value = ConvertToTargetResolution.Convert(look.magnitude);
            float ratio = MoveStickData.Dist.m_Value / radius;
            MoveStickData.MoveSpeedRate.m_Value = Mathf.Clamp01(ratio);
            MoveStickData.ClampedEndPos.m_Value =
                MoveStickData.StartPos.m_Value
                + (MoveStickData.Dir.m_Value
                * MoveStickData.MoveSpeedRate.m_Value 
                * ConvertToScreenResolution.Convert(radius));
            MoveStickData.ClampedEndPos.m_Dirty++;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        MoveStickData.IsTouch.m_Value = false;
        MoveStickData.IsTouch.m_Dirty++;
        MoveStickData.MoveSpeedRate.m_Value = 0;
    }
}
