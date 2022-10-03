using System.Collections;
using UnityEngine;

public class DestroyAllArcade
{
    public static void Set()
    {
        var arr = GameObject.FindGameObjectsWithTag("Arcade");
        for (int i = 0; i < arr.Length; i++)
            GameObject.Destroy(arr[i]);
    }
}