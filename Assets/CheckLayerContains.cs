using System.Collections;
using UnityEngine;
public class CheckLayerContains
{
    public static bool Check(LayerMask layerMask, int layerIndex)
    {
        var layer = 1 << layerIndex;
        if ((layerMask.value & layer) != 0)
            return true;
        return false;
    }
}