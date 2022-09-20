using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateCamZoom : MonoBehaviour
{
    Transform m_Tf;
    // Start is called before the first frame update
    void Start()
    {
        m_Tf = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (CamZoomData.IsPush.m_Value)
        {
            var localPos = m_Tf.localPosition;
            localPos.z += CamZoomData.Delta.m_Value * CamZoomData.Speed.m_Value;
            localPos.z = Mathf.Clamp(localPos.z, -CamZoomData.Limit.m_Max, -CamZoomData.Limit.m_Min);
            m_Tf.localPosition = localPos;
        }
    }
}
