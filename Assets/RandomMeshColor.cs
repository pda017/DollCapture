using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMeshColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var render = GetComponent<Renderer>();
        render.material.color = Random.ColorHSV();
    }
}
