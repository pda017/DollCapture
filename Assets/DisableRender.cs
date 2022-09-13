using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableRender : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var render = GetComponent<Renderer>();
        if(render != null)
            render.enabled = false;
    }
}
