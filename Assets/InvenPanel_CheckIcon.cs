using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InvenPanel_CheckIcon : MonoBehaviour
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
        if (InvenData.SellAllMode.m_Value)
        {
            var index = m_IndexTf.GetSiblingIndex();
            if (InvenData.SellList.m_Value.Contains(index))
                m_Image.enabled = true;
            else
                m_Image.enabled = false;
        }
        else
            m_Image.enabled = false;
    }
}
