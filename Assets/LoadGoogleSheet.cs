using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGoogleSheet
{
    public static void LoadAll()
    {
        LoadSheet("1KEy7DpaaEJbcVygtShBJvh47R6qY0ziWp7gVJLUy07Q", "0"); //PartsTable
    }
    public static void LoadSheet(string docid, string gid)
    {
        var csvDownloader = new CsvDownloader();
        var csvParser = new CsvParser();
        csvDownloader.RequestSheetData(docid, gid, () =>
        {
            if (csvDownloader.m_Success)
            {
                csvParser.Parse(csvDownloader.m_Result);
                var table = csvParser.m_DataTable;
                foreach (var pair in table)
                {
                    DataParser.Parse(pair.Key, pair.Value);
                }
            }
        });

    }
}
