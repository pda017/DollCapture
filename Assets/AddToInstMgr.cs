using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddToInstMgr : MonoBehaviour
{
    private void OnEnable()
    {
        InstMgr.Add(gameObject);
    }
    private void OnDisable()
    {
        InstMgr.Remove(gameObject);
    }
}
