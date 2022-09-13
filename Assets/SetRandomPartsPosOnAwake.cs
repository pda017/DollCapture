using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRandomPartsPosOnAwake : MonoBehaviour
{
    SetRandomPose m_SetRandomPose;
    SetRandomCharParts m_SetRandomCharParts;
    // Start is called before the first frame update
    void Start()
    {
        m_SetRandomPose = new SetRandomPose(gameObject);
        m_SetRandomCharParts = new SetRandomCharParts(gameObject);
        m_SetRandomCharParts.Set();
        m_SetRandomPose.SetSequence();
    }
}
