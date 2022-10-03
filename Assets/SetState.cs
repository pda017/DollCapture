using System.Collections;
using UnityEngine;

public class SetState
{
    public static void Set(string objName,StateEnum stateEnum)
    {
        var state = Finder.Find<State>(objName);
        state.m_Value = stateEnum;
        state.m_Dirty++;
    }
}