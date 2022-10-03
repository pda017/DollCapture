using System.Collections;
using UnityEngine;

public class AddObjToDioramaRoom
{
    public static bool AddSelected()
    {
        var roomInfo = GetSelectedDioramaRoomInfo.Get();
        if (roomInfo != null)
        {
            var itemInfo = GetInvenItemInfo.Get(DioramaData.ItemIndex.m_Value);
            if (itemInfo != null)
            {
                InvenData.Inventory.m_Value.RemoveAt(DioramaData.ItemIndex.m_Value);
                InvenData.Inventory.m_Dirty++;
                var objInfo = new DioramaObjInfo();
                objInfo.m_Pos = Finder.FindObject("CreateObjPos").transform.position;
                objInfo.m_Key = itemInfo.m_Key;
                objInfo.m_Prefab = itemInfo.m_DollPrefab;
                objInfo.m_Rot = Vector3.zero;
                roomInfo.m_ObjList.Add(objInfo);
                DioramaData.DioramaRoomList.m_Dirty++;
                DioramaData.ModifyItemIndex.m_Value = roomInfo.m_ObjList.Count - 1;
                return true;
            }
        }
        return false;
    }
}