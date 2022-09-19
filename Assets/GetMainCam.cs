using System.Collections;
using UnityEngine;

public class GetMainCam
{
    static Camera m_Cam = null;
    static Transform m_CamTf = null;
    public static Camera Get()
    {
        if (m_Cam == null)
            m_Cam = Camera.main;
        return m_Cam;
    }
    public static Transform GetTf()
    {
        if (m_CamTf == null)
        {
            var cam = Get();
            if (cam != null)
                m_CamTf = cam.transform;
        }
        return m_CamTf;
    }
}