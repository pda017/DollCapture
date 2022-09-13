using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateCharPose : MonoBehaviour
{
    CharPose m_CharPose;
    CharParts m_CharParts;
    float m_PoseDirty = float.MinValue;
    float m_PartsDirty = float.MinValue;
    ApplyCharPose m_ApplyCharPose;
    // Start is called before the first frame update
    void Start()
    {
        m_CharParts = GetComponent<CharParts>();
        m_CharPose = GetComponent<CharPose>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_PoseDirty != m_CharPose.m_Dirty
            || m_PartsDirty != m_CharParts.m_Dirty)
        {
            m_PoseDirty = m_CharPose.m_Dirty;
            m_PartsDirty = m_CharParts.m_Dirty;

            ApplyCharPose.Apply(gameObject, m_CharPose.m_Value);
        }
    }
}
