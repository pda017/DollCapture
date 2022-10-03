using System.Collections;
using UnityEngine;

public class GetClawLineState
{
    State m_State;
    public State Get()
    {
        if (m_State == null)
        {
            var arcadeObj = GameObject.FindWithTag("Arcade");
            var lineTag = arcadeObj.GetComponentInChildren<ClawLineTag>();
            m_State = lineTag.GetComponent<State>();
        }
        return m_State;
    }
}