using System.Collections;
using UnityEngine;

public class LayerData
{
    static Data_Layer m_Doll;
    public static Data_Layer Doll
    {
        get
        {
            if (m_Doll == null)
                m_Doll = Resources.Load<Data_Layer>("Data/Layer/Doll");
            return m_Doll;
        }
    }
    static Data_Layer m_CaseFloor;
    public static Data_Layer CaseFloor
    {
        get
        {
            if (m_CaseFloor == null)
                m_CaseFloor = Resources.Load<Data_Layer>("Data/Layer/CaseFloor");
            return m_CaseFloor;
        }
    }
}