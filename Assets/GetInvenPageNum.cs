using System.Collections;
using UnityEngine;

public class GetInvenPageNum
{
    public static int Get()
    {
        return Mathf.CeilToInt(InvenData.Inventory.m_Value.Count / (float)InvenData.PageNodeNum.m_Value);
    }
}