using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddToFinder : MonoBehaviour
{
    public bool m_IsInstantiated = false;
    private void Awake()
    {
        if (m_IsInstantiated)
            Finder.AddToDic(gameObject);
    }
}
