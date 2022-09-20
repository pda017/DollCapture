using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTargetFps : MonoBehaviour
{
    public int m_Fps;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = m_Fps;
    }
}
