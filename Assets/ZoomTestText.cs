using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomTestText : MonoBehaviour
{
    ZText m_Text;
    Camera m_MainCam;
    // Start is called before the first frame update
    void Start()
    {
        m_MainCam = Camera.main;
        m_Text = new ZText(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        m_Text.SetText("IsPush : {0}\nDelta : {1}\nZoomDist : {2}"
            , CamZoomData.IsPush.m_Value, CamZoomData.Delta.m_Value
            , -m_MainCam.transform.localPosition.z);
    }
}
