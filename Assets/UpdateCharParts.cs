using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateCharParts : MonoBehaviour
{
    CharPartsType m_CharPartsType;
    CharPartsChanged m_CharPartsChanged;
    CharParts m_CharParts;
    Transform m_Tf;
    SkinnedMeshRenderer m_BaseMesh;
    // Start is called before the first frame update
    void Start()
    {
        m_Tf = transform;
        m_CharParts = GetComponentInParent<CharParts>();
        m_CharPartsType = GetComponent<CharPartsType>();
        m_CharPartsChanged = new CharPartsChanged(gameObject);
        var anim = GetComponentInParent<Animator>();
        var baseBodyTag = anim.GetComponentInChildren<BaseBodyTag>();
        m_BaseMesh = baseBodyTag.GetComponent<SkinnedMeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_CharPartsChanged.Check())
        {
            string partsKey = CharPartsTypeToKey.Convert(m_CharPartsType.m_Value,m_CharParts);

            var partsInfo = GetCharPartsInfo.Get(partsKey);

            if (partsInfo == null)
            {
                DestroyChild();
            }
            else
            {
                if (m_Tf.childCount != 0)
                {
                    if (m_Tf.GetChild(0).name.CompareTo(partsInfo.m_Prefab) == 0)
                        return;
                }
                DestroyChild();
                var newParts = CharPartsMgr.Create(partsInfo.m_Prefab);
                if (newParts != null)
                {
                    var newPartsTf = newParts.transform;
                    newPartsTf.parent = m_Tf;
                    newPartsTf.localRotation = Quaternion.identity;
                    newPartsTf.localPosition = Vector3.zero;
                    newPartsTf.localScale = Vector3.one;
                    var newPartsMesh = newParts.GetComponent<SkinnedMeshRenderer>();
                    if (newPartsMesh != null)
                    {
                        newPartsMesh.bones = m_BaseMesh.bones;
                        newPartsMesh.rootBone = m_BaseMesh.rootBone;
                    }
                }
            }
        }
    }
    void DestroyChild()
    {
        for (int i = 0; i < m_Tf.childCount; i++)
        {
            var child = m_Tf.GetChild(i);
            Destroy(child.gameObject);
        }
    }
}
