using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parser_ArcadeTable
{
    public static void Parse(List<List<string>> dataTable)
    {
        var list = ArcadeCaseData.ArcadeList.m_Value;
        list.Clear();
        List<string> columnList = null;
        for (int i = 0; i < dataTable.Count; i++)
        {
            var line = dataTable[i];
            if (i == 0)
                columnList = line;
            else
            {
                var info = new ArcadeInfo();
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
                    else if (column.CompareTo("Prefab") == 0)
                    {
                        info.m_Prefab = value;
                    }
                    else if (column.CompareTo("Cost") == 0)
                    {
                        int v;
                        if (int.TryParse(value, out v))
                            info.m_Cost = v;
                    }
                    else if (column.Contains("Item"))
                    {
                        info.m_Item.Add(value);
                    }
                }
            }
        }
        SetDirtyObj.Set(ArcadeCaseData.ArcadeList);
    }
}
