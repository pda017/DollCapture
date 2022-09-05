using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckClawGrabbed : MonoBehaviour
{
    GrabAngle m_GrabAngle;
    IsGrabbed m_IsGrabbed;
    List<HingeJoint> m_HingeList = new List<HingeJoint>();
    // Start is called before the first frame update
    void Start()
    {
        m_GrabAngle = GetComponent<GrabAngle>();
        m_IsGrabbed = GetComponent<IsGrabbed>();
        m_HingeList.AddRange(GetComponentsInChildren<HingeJoint>());
    }

    // Update is called once per frame
    void Update()
    {
        m_IsGrabbed.m_Value = true;
        for (int i = 0; i < m_HingeList.Count; i++)
        {
            var hinge = m_HingeList[i];
            if (hinge.spring.targetPosition < m_GrabAngle.m_GrabAngle)
            {
                m_IsGrabbed.m_Value = false;
                return;
            }
        }
    }
}
