using System.Collections;
using UnityEngine;

public class LayerData
{
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