using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionPanel_CollectRateText : MonoBehaviour
{
    ZText m_Text;
    ItemListChanged m_ItemListChagned;
    // Start is called before the first frame update
    void Start()
    {
        m_Text = new ZText(gameObject);
        m_ItemListChagned = new ItemListChanged();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_ItemListChagned.Check())
        {
            int percent = Mathf.RoundToInt(GetCollectRate.Get() * 100f);
            m_Text.SetText("{0}%", percent);
        }
    }
}
