using System.Collections;
using UnityEngine;

public class ClearDolls
{
    public static void Set()
    {
        var dolls = GameObject.FindGameObjectsWithTag("Doll");
        for (int i = 0; i < dolls.Length; i++)
        {
            GameObject.Destroy(dolls[i]);
        }
    }
}