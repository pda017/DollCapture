using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parser_PartsTable
{
    public static void Parse(List<List<string>> dataTable)
    {
        var list = CharPartsData.CharPartsList.m_Value;
        list.Clear();
        List<string> columnList = null;
        for (int i = 0; i < dataTable.Count; i++)
        {
            var line = dataTable[i];
            if (i == 0)
                columnList = line;
            else
            {
                var info = new CharPartsInfo();
                list.Add(info);
                for (int k = 0; k < line.Count; k++)
                {
                    var column = columnList[k];
                    var value = line[k];
                    if (column.CompareTo("Key") == 0)
                    {
                        info.m_Key = value;
                    }
                    else if (column.CompareTo("Type") == 0)
                    {
                        info.m_Type = EnumParse.Parse<CharPartsEnum>(value);
                    }
                    else if (column.CompareTo("Prefab") == 0)
                    {
                        info.m_Prefab = value;
                    }
                }
            }
        }
        SetDirtyObj.Set(CharPartsData.CharPartsList);
    }
}
