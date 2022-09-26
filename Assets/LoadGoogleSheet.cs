using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGoogleSheet
{
    public static void LoadAll()
    {
        LoadSheet("1KEy7DpaaEJbcVygtShBJvh47R6qY0ziWp7gVJLUy07Q", "0"); //PartsTable
        LoadSheet("1vWmvHNupDyE24x_uGSPwhaf5yt3rupnu8NoqTYyhcSk", "0"); //ItemTable
        LoadSheet("1XqbERc5i7UuU4llGmzKS7KQIIbViV4Ydnyl5O2GWECU", "0"); //ArcadeTable
        LoadSheet("1ctwHrF-MJM2G0Dh9WUpis1UNcTrkHTEubKmiyIpI3E4", "0"); //CollectionTable
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
