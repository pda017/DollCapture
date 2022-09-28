using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;

public class LoadIcon : MonoBehaviour
{
    Camera m_IconCam;
    GameObject m_IconChar;
    CharParts m_CharParts;
    CharPose m_CharPose;
    int m_Index = 0;
    int m_NumState = 0;
    ItemInfo m_ItemInfo;
    // Start is called before the first frame update
    void Start()
    {
        ItemData.IconList.m_Value.Clear();
        m_IconCam = Finder.Find<Camera>("IconCamera");
        m_IconChar = Finder.FindObject("IconChar");
        m_CharParts = m_IconChar.GetComponentInChildren<CharParts>();
        m_CharPose = m_IconChar.GetComponentInChildren<CharPose>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_NumState == 0)
        {
            if (m_Index < ItemData.ItemList.m_Value.Count)
            {
                m_ItemInfo = ItemData.ItemList.m_Value[m_Index];
                CharPartsCopy.Set(m_ItemInfo.m_CharParts, m_CharParts.m_Value);
                m_CharParts.m_Dirty++;
                m_CharPose.m_Value = m_ItemInfo.m_Pose;
                m_CharPose.m_Dirty++;
                m_IconChar.BroadcastMessage("Update", SendMessageOptions.DontRequireReceiver);
                m_NumState++;
            }
            else
            {
                SceneMgr.LoadNextScene();
            }
        }
        else if (m_NumState == 1)
        {
            var rt = m_IconCam.targetTexture;
            m_IconCam.targetTexture = null;
            m_IconCam.targetTexture = rt;
            m_IconCam.Render();
            var tex = new Texture2D(rt.width, rt.height, TextureFormat.RGBA32, false);
            RenderTexture.active = rt;
            tex.ReadPixels(new Rect(0, 0, rt.width, rt.height), 0, 0);
            tex.Apply();
            RenderTexture.active = null;

            var iconInfo = new IconInfo();
            iconInfo.m_Key = m_ItemInfo.m_Key;
            iconInfo.m_Tex = tex;
            ItemData.IconList.m_Value.Add(iconInfo);
            m_Index++;
            m_NumState = 0;
        }
    }
}
