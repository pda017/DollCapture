using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumParse
{
    public static T Parse<T>(string str) where T : System.Enum
    {
        return (T)System.Enum.Parse(typeof(T), str);
    }
}
