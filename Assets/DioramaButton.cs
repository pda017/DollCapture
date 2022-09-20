using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DioramaButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ButtonEvent.AddClickEvent(gameObject, () =>
        {
            SceneMgr.LoadScene("Diorama");
        });
    }
}
