using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalState : MonoBehaviour
{
    Transform m_Tf;
    public Transform m_StateTf;
    // Start is called before the first frame update
    void Awake()
    {
        m_Tf = transform;
        //
        m_StateTf = m_Tf.Find("State");
        if (m_StateTf != null)
        {
            m_StateTf.parent = null;
            var owner = m_StateTf.GetComponent<Owner>();
            owner.m_Value = gameObject;
            m_StateTf.name = string.Format("{0}_{1}", gameObject.name, m_StateTf.name);
        }
    }
    private void OnDestroy()
    {
        if (m_StateTf != null)
            Destroy(m_StateTf.gameObject);
    }
    private void OnEnable()
    {
        if (m_StateTf != null)
            m_StateTf.gameObject.SetActive(true);
    }
    private void OnDisable()
    {
        if (m_StateTf != null)
            m_StateTf.gameObject.SetActive(false);
    }
}
