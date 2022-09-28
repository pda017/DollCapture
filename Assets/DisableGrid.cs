using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisableGrid : MonoBehaviour
{
    GridLayoutGroup m_Grid;
    int m_NumState = 0;
    // Start is called before the first frame update
    void Start()
    {
        m_Grid = GetComponent<GridLayoutGroup>();
    }
    private void Update()
    {
        if (m_NumState == 0)
        {
            if(m_Grid.enabled)
                m_NumState++;
        }
        else if (m_NumState == 1)
        {
            m_Grid.enabled = false;
            m_NumState = 0;
        }
    }
}
