#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class ConnectJointToParentMenu
{
    [MenuItem("GameObject/Custom/ConnectJointToParent", false, 10)]
    // Start is called before the first frame update
    public static void DoSomething()
    {
        foreach (var targetObj in Selection.gameObjects)
        {
            var parentRigid = targetObj.transform.parent.GetComponent<Rigidbody>();
            var joint = targetObj.GetComponent<Joint>();

            if (parentRigid != null && joint != null)
            {
                joint.connectedBody = parentRigid;
            }
            SetDirtyObj.Set(targetObj);
        }
    }
}
#endif