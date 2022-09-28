using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parser_ItemTable
{
    public static void Parse(List<List<string>> dataTable)
    {
        var list = ItemData.ItemList.m_Value;
        list.Clear();
        List<string> columnList = null;
        for (int i = 0; i < dataTable.Count; i++)
        {
            var line = dataTable[i];
            if (i == 0)
                columnList = line;
            else
            {
                var info = new ItemInfo();
                list.Add(info);
                for (int k = 0; k < line.Count; k++)
                {
                    var column = columnList[k];
                    var value = line[k];
                    if (column.CompareTo("Key") == 0)
                    {
                        info.m_Key = value;
                    }
                    else if (column.CompareTo("Name") == 0)
                    {
                        info.m_Name = value;
                    }
                    else if (column.CompareTo("Desc") == 0)
                    {
                        info.m_Desc = value;
                    }
                    else if (column.CompareTo("IsDoll") == 0)
                    {
                        bool bValue;
                        if(bool.TryParse(value.ToLower(),out bValue))
                            info.m_IsDoll = bValue;
                    }
                    else if (column.CompareTo("DollPrefab") == 0)
                    {
                        info.m_DollPrefab = value;
                    }
                    else if (column.CompareTo("IconPrefab") == 0)
                    {
                        info.m_IconPrefab = value;
                    }
                    else if (column.CompareTo("Cost") == 0)
                    {
                        int v;
                        if (int.TryParse(value, out v))
                            info.m_Cost = v;
                    }
                    else if (column.CompareTo("Pose") == 0)
                    {
                        info.m_Pose = value;
                    }
                    else if (column.CompareTo("Body") == 0)
                    {
                        info.m_CharParts.m_Body = value;
                    }
                    else if (column.CompareTo("Cloth") == 0)
                    {
                        info.m_CharParts.m_Cloth = value;
                    }
                    else if (column.CompareTo("Glass") == 0)
                    {
                        info.m_CharParts.m_Glass = value;
                    }
                    else if (column.CompareTo("Hair") == 0)
                    {
                        info.m_CharParts.m_Hair = value;
                    }
                    else if (column.CompareTo("Hat") == 0)
                    {
                        info.m_CharParts.m_Hat = value;
                    }
                    else if (column.CompareTo("Head") == 0)
                    {
                        info.m_CharParts.m_Head = value;
                    }
                    else if (column.CompareTo("Gun") == 0)
                    {
                        info.m_CharParts.m_Gun = value;
                    }
                }
            }
        }
        SetDirtyObj.Set(ItemData.ItemList);
    }
}
