using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinText : MonoBehaviour
{
    ZText m_Text;
    CoinChanged m_CoinChanged;
    // Start is called before the first frame update
    void Start()
    {
        m_CoinChanged = new CoinChanged();
        m_Text = new ZText(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (m_CoinChanged.Check())
        {
            m_Text.SetText("{0}", InvenData.Coin.m_Value);
        }
    }
}
