using UnityEngine;
using System.Collections;
public class WaitTime
{
    float m_Stamp;
    float m_Time;
    public WaitTime(float time)
    {
        m_Time = time;
    }
    public WaitTime()
    {
    }
    public void SetTime(float time)
    {
        m_Time = time;
    }
    public void Start()
    {
        m_Stamp = Time.time;
    }
    public bool End()
    {
        if (Time.time - m_Stamp > m_Time)
            return true;
        return false;
    }
    public bool End(float time)
    {
        m_Time = time;
        return End();
    }
    public void Reset()
    {
        m_Stamp = float.MinValue;
    }
}