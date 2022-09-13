using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateLineCutOffHeight : MonoBehaviour
{
    public float m_Height;
    Renderer m_Render;
    Material m_Mat;
    // Start is called before the first frame update
    void Start()
    {
        m_Render = GetComponent<Renderer>();
        m_Mat = m_Render.material;
    }

    // Update is called once per frame
    void Update()
    {
        m_Mat.SetFloat("_CutoutHeight", m_Height + 0.5f);
    }
    private void OnDrawGizmosSelected()
    {
        var pos = transform.position;
        pos.y = m_Height;
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(pos, new Vector3(2, 0, 2));
    }
}
