using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Reflection;
public class DataParser
{
    public static void Parse(string parserName, List<List<string>> dataTable)
    {
        var parser = Type.GetType(string.Format("Parser_{0}", parserName));
        if (parser != null)
        {
            parser.GetMethod("Parse").Invoke(null, new object[] { dataTable });
            Debug.LogFormat("Complete {0}", parserName);
        }
    }
}
