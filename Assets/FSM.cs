using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSM
{
    State m_State;
    StateEnum m_PrevState;
    float m_Dirty = float.MinValue;
    public int m_NumState = 0;
    public FSM(GameObject owner)
    {
        m_State = owner.GetComponent<State>();
    }
    public bool Begin(StateEnum state)
    {
        if (state == m_State.m_Value)
        {
            if (m_Dirty != m_State.m_Dirty)
            {
                m_Dirty = m_State.m_Dirty;
                m_NumState = 0;
            }
            return true;
        }
        return false;
    }
    public StateEnum GetState()
    {
        return m_State.m_Value;
    }
    public void SetState(StateEnum state,StateEnum returnState)
    {
        m_PrevState = returnState;
        m_State.m_Value = state;
        m_State.m_Dirty++;
    }
    public void SetState(StateEnum state)
    {
        m_State.m_Value = state;
        m_State.m_Dirty++;
    }
    public void ReturnState()
    {
        m_State.m_Value = m_PrevState;
        m_State.m_Dirty++;
    }
    public void NextNumState()
    {
        m_NumState++;
    }
    public bool BeginNumState(int numState)
    {
        return m_NumState == numState;
    }
    public void SetNumState(int numState)
    {
        m_NumState = numState;
    }
}
