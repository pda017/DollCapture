using System.Collections;
using UnityEngine;

public class GetMainCam
{
    static Camera m_Cam = null;
    public static Camera Get()
    {
        if (m_Cam == null)
            m_Cam = Camera.main;
        return m_Cam;
    }
}