using System.Collections;
using UnityEngine;

public class GetPageNum
{
    public static int Get(int nodeNum,int pageNodeNum)
    {
        return Mathf.CeilToInt(nodeNum / (float)pageNodeNum);
    }
}