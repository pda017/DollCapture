using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamPivot : MonoBehaviour
{
    CamRotator m_CamRotator;
    // Start is called before the first frame update
    void Start()
    {
        m_CamRotator = new CamRotator(gameObject);
        m_CamRotator.InitRot();
    }

    // Update is called once per frame
    void Update()
    {
        if (CamRotateData.IsPush.m_Value)
        {
            m_CamRotator.Update(CamRotateData.MoveDelta.m_Value
                , CamRotateData.RotSpeed.m_Value
                , CamRotateData.AngleLimit.m_Min
                , CamRotateData.AngleLimit.m_Max);
        }
    }
}
