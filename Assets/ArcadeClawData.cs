using System.Collections;
using UnityEngine;

public class ArcadeClawData
{
    static Data_Bool m_ClawOnDropPosZ;
    public static Data_Bool ClawOnDropPosZ
    {
        get
        {
            if (m_ClawOnDropPosZ == null)
                m_ClawOnDropPosZ = Resources.Load<Data_Bool>("Data/ArcadeClaw/ClawOnDropPosZ");
            return m_ClawOnDropPosZ;
        }
    }
    static Data_Bool m_ClawOnDropPosX;
    public static Data_Bool ClawOnDropPosX
    {
        get
        {
            if (m_ClawOnDropPosX == null)
                m_ClawOnDropPosX = Resources.Load<Data_Bool>("Data/ArcadeClaw/ClawOnDropPosX");
            return m_ClawOnDropPosX;
        }
    }
    static Data_Float m_DropBoundsClawTipColDirty;
    public static Data_Float DropBoundsClawTipColDirty
    {
        get
        {
            if (m_DropBoundsClawTipColDirty == null)
                m_DropBoundsClawTipColDirty = Resources.Load<Data_Float>("Data/ArcadeClaw/DropBoundsClawTipColDirty");
            return m_DropBoundsClawTipColDirty;
        }
    }
    static Data_Float m_DropCheckDist;
    public static Data_Float DropCheckDist
    {
        get
        {
            if (m_DropCheckDist == null)
                m_DropCheckDist = Resources.Load<Data_Float>("Data/ArcadeClaw/DropCheckDist");
            return m_DropCheckDist;
        }
    }
    static Data_Float m_DropCheckRadius;
    public static Data_Float DropCheckRadius
    {
        get
        {
            if (m_DropCheckRadius == null)
                m_DropCheckRadius = Resources.Load<Data_Float>("Data/ArcadeClaw/DropCheckRadius");
            return m_DropCheckRadius;
        }
    }
    static Data_Float m_GrabCheckDist;
    public static Data_Float GrabCheckDist
    {
        get
        {
            if (m_GrabCheckDist == null)
                m_GrabCheckDist = Resources.Load<Data_Float>("Data/ArcadeClaw/GrabCheckDist");
            return m_GrabCheckDist;
        }
    }
    static Data_Int m_GrabDoll_Id;
    public static Data_Int GrabDoll_Id
    {
        get
        {
            if (m_GrabDoll_Id == null)
                m_GrabDoll_Id = Resources.Load<Data_Int>("Data/ArcadeClaw/GrabDoll_Id");
            return m_GrabDoll_Id;
        }
    }
    static Data_Float m_DropTime;
    public static Data_Float DropTime
    {
        get
        {
            if (m_DropTime == null)
                m_DropTime = Resources.Load<Data_Float>("Data/ArcadeClaw/DropTime");
            return m_DropTime;
        }
    }
    static Data_Float m_DropReadyTime;
    public static Data_Float DropReadyTime
    {
        get
        {
            if (m_DropReadyTime == null)
                m_DropReadyTime = Resources.Load<Data_Float>("Data/ArcadeClaw/DropReadyTime");
            return m_DropReadyTime;
        }
    }
    static Data_Float m_BackWallColDirty;
    public static Data_Float BackWallColDirty
    {
        get
        {
            if (m_BackWallColDirty == null)
                m_BackWallColDirty = Resources.Load<Data_Float>("Data/ArcadeClaw/BackWallColDirty");
            return m_BackWallColDirty;
        }
    }
    static Data_Float m_ForwardWallColDirty;
    public static Data_Float ForwardWallColDirty
    {
        get
        {
            if (m_ForwardWallColDirty == null)
                m_ForwardWallColDirty = Resources.Load<Data_Float>("Data/ArcadeClaw/ForwardWallColDirty");
            return m_ForwardWallColDirty;
        }
    }
    static Data_Float m_LeftWallColDirty;
    public static Data_Float LeftWallColDirty
    {
        get
        {
            if (m_LeftWallColDirty == null)
                m_LeftWallColDirty = Resources.Load<Data_Float>("Data/ArcadeClaw/LeftWallColDirty");
            return m_LeftWallColDirty;
        }
    }
    static Data_Float m_RightWallColDirty;
    public static Data_Float RightWallColDirty
    {
        get
        {
            if (m_RightWallColDirty == null)
                m_RightWallColDirty = Resources.Load<Data_Float>("Data/ArcadeClaw/RightWallColDirty");
            return m_RightWallColDirty;
        }
    }
    static Data_Float m_DownDirty;
    public static Data_Float DownDirty
    {
        get
        {
            if (m_DownDirty == null)
                m_DownDirty = Resources.Load<Data_Float>("Data/ArcadeClaw/DownDirty");
            return m_DownDirty;
        }
    }
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