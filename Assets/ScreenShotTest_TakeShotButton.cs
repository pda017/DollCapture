using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScreenShotTest_TakeShotButton : MonoBehaviour
{
    public RawImage m_Image;
    public Camera m_IconCam;
    public GameObject m_BaseChar;
    CharParts m_CharParts;
    // Start is called before the first frame update
    void Start()
    {
        m_CharParts = m_BaseChar.GetComponentInChildren<CharParts>();
        ButtonEvent.AddClickEvent(gameObject, () =>
        {
            SetRandomCharParts.Set(m_CharParts);
            m_BaseChar.BroadcastMessage("Update", SendMessageOptions.DontRequireReceiver);
            var rt = m_IconCam.targetTexture;
            m_IconCam.targetTexture = null;
            m_IconCam.targetTexture = rt;
            m_IconCam.Render();
            var tex = new Texture2D(rt.width, rt.height, TextureFormat.RGB24, false);
            RenderTexture.active = rt;
            tex.ReadPixels(new Rect(0, 0, rt.width, rt.height), 0, 0);
            tex.Apply();
            RenderTexture.active = null;

            m_Image.texture = tex;
        });
    }
}
