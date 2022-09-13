using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsvParser
{
    public Dictionary<string, List<List<string>>> m_DataTable = null;
    public void Parse(string csvText)
    {
        m_DataTable = new Dictionary<string, List<List<string>>>();
        string tableValue = string.Empty;
        string tableName = string.Empty;
        List<string> colList = null;
        List<List<string>> rowList = null;
        int numState = 0;
        for (int i = 0; i < csvText.Length; i++)
        {

            char c = csvText[i];

            if (numState == 0)
            {
                if (c == '[')
                {
                    tableName = string.Empty;
                    numState = 1;
                    continue;
                }
                if (c == '\n' || c == ',' || c == '\r')
                    continue;
                if (c == '/')
                {
                    numState = 4;
                    continue;
                }
                if (c == 34) // " Code
                {
                    numState = 5;
                    continue;
                }
                colList = new List<string>();
                tableValue = string.Empty;
                tableValue += c;
                numState = 2;
            }
            else if (numState == 1)
            {
                if (c == ']')
                {
                    tableName = tableName.Trim();
                    rowList = new List<List<string>>();
                    m_DataTable[tableName] = rowList;
                    numState = 0;
                    continue;
                }
                tableName += c;
            }
            else if (numState == 2)
            {
                if (c == 34) // " Code
                {
                    numState = 3;
                    continue;
                }
                if (c == ',')
                {
                    AddColList(colList, tableValue);
                    tableValue = string.Empty;
                    continue;
                }
                if (c == '\n')
                {
                    AddColList(colList, tableValue);
                    rowList.Add(colList);
                    numState = 0;
                    continue;
                }
                tableValue += c;
            }
            else if (numState == 3)
            {
                if (c == 34) // " Code
                {
                    numState = 2;
                    continue;
                }
                tableValue += c;
            }
            else if (numState == 4)
            {
                if (c == ',' || c == '\n' || c == '\r')
                {
                    numState = 0;
                    continue;
                }
            }
            else if (numState == 5)
            {
                if (c == 34) // " Code
                {
                    numState = 0;
                    continue;
                }
            }
        }
        AddColList(colList, tableValue);
        rowList.Add(colList);
    }
    void AddColList(List<string> colList, string tableValue)
    {
        tableValue = tableValue.Trim();
        if (!IsRemark(tableValue) && !string.IsNullOrEmpty(tableValue))
            colList.Add(tableValue);
    }
    bool IsRemark(string token)
    {
        if (token.StartsWith("//"))
            return true;
        return false;
    }
}
