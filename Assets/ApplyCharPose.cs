using System.Collections;
using UnityEngine;

public class ApplyCharPose
{
    public static void Apply(SkinnedMeshRenderer targetMesh, string key)
    {
        var poseObj = PrefabMgr.Get(key);
        if (poseObj != null)
        {
            var copyMesh = poseObj.GetComponentInChildren<SkinnedMeshRenderer>();
            for (int i = 0; i < copyMesh.bones.Length; i++)
            {
                var copyBone = copyMesh.bones[i];
                var targetBone = targetMesh.bones[i];

                targetBone.localRotation = copyBone.localRotation;
            }
        }
    }
    public static void Apply(GameObject targetObj, string key)
    {
        var bodyPartsTag = targetObj.GetComponentInChildren<BaseBodyTag>();
        if (bodyPartsTag != null)
        {
            var bodyMesh = bodyPartsTag.GetComponent<SkinnedMeshRenderer>();
            if(bodyMesh != null)
                Apply(bodyMesh, key);
        }
    }
}