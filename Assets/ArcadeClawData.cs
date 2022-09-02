using System.Collections;
using UnityEngine;

public class ArcadeClawData
{
    static Data_Float m_DollColDirty;
    public static Data_Float DollColDirty
    {
        get
        {
            if (m_DollColDirty == null)
                m_DollColDirty = Resources.Load<Data_Float>("Data/ArcadeClaw/DollColDirty");
            return m_DollColDirty;
        }
    }
    static Data_Float m_FloorColDirty;
    public static Data_Float FloorColDirty
    {
        get
        {
            if (m_FloorColDirty == null)
                m_FloorColDirty = Resources.Load<Data_Float>("Data/ArcadeClaw/FloorColDirty");
            return m_FloorColDirty;
        }
    }
}