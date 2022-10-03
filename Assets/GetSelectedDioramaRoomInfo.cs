using System.Collections;
using UnityEngine;

public class GetSelectedDioramaRoomInfo
{
    public static DioramaRoomInfo Get()
    {
        var index = DioramaData.SelectedRoomIndex.m_Value;
        if (index < DioramaData.DioramaRoomList.m_Value.Count)
            return DioramaData.DioramaRoomList.m_Value[index];
        return null;
    }
}