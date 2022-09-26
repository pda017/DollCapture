using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parser_CollectionTable
{
    public static void Parse(List<List<string>> dataTable)
    {
        var list = CollectionData.CollectionList.m_Value;
        list.Clear();
        List<string> columnList = null;
        for (int i = 0; i < dataTable.Count; i++)
        {
            var line = dataTable[i];
            if (i == 0)
                columnList = line;
            else
            {
                var info = new CollectionInfo();
                list.Add(info);
                for (int k = 0; k < line.Count; k++)
                {
                    var column = columnList[k];
                    var value = line[k];
                    if (column.CompareTo("Key") == 0)
                    {
                        info.m_Key = value;
                    }
                    else if (column.Contains("Item"))
                    {
                        info.m_ItemList.Add(value);
                    }
                }
            }
        }
        SetDirtyObj.Set(CollectionData.CollectionList);
    }
}
