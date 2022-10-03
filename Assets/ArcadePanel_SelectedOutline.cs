using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ArcadePanel_SelectedOutline : MonoBehaviour
{
    Image m_Image;
    Transform m_IndexTf;
    // Start is called before the first frame update
    void Start()
    {
        m_IndexTf = GetComponentInParent<IndexTag>().transform;
        m_Image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        var index = m_IndexTf.GetSiblingIndex();
        if (index == ArcadeCaseData.SelectedArcadeIndex.m_Value)
            m_Image.enabled = true;
        else
            m_Image.enabled = false;
    }
}
