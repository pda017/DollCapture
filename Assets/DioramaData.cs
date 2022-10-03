using System.Collections;
using UnityEngine;

public class DioramaData
{
    static Data_Int m_ModifyItemIndex;
    public static Data_Int ModifyItemIndex
    {
        get
        {
            if (m_ModifyItemIndex == null)
                m_ModifyItemIndex = Resources.Load<Data_Int>("Data/Diorama/ModifyItemIndex");
            return m_ModifyItemIndex;
        }
    }
    static Data_Int m_ItemIndex;
    public static Data_Int ItemIndex
    {
        get
        {
            if (m_ItemIndex == null)
                m_ItemIndex = Resources.Load<Data_Int>("Data/Diorama/ItemIndex");
            return m_ItemIndex;
        }
    }
    static Data_DioramaRoomList m_DioramaRoomList;
    public static Data_DioramaRoomList DioramaRoomList
    {
        get
        {
            if (m_DioramaRoomList == null)
                m_DioramaRoomList = Resources.Load<Data_DioramaRoomList>("Data/Diorama/DioramaRoomList");
            return m_DioramaRoomList;
        }
    }
    static Data_Int m_SelectedRoomIndex;
    public static Data_Int SelectedRoomIndex
    {
        get
        {
            if (m_SelectedRoomIndex == null)
                m_SelectedRoomIndex = Resources.Load<Data_Int>("Data/Diorama/SelectedRoomIndex");
            return m_SelectedRoomIndex;
        }
    }
}