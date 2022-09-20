using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenText : MonoBehaviour
{
    ZText m_Text;
    TokenChanged m_TokenChanged;
    // Start is called before the first frame update
    void Start()
    {
        m_Text = new ZText(gameObject);
        m_TokenChanged = new TokenChanged();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_TokenChanged.Check())
        {
            m_Text.SetText("{0}",InvenData.Token.m_Value);
        }
    }
}
