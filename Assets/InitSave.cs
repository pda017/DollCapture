using System.Collections;
using UnityEngine;

public class InitSave
{
    public static void Set()
    {
        ArcadeCaseData.BuyList.m_Value.Clear();
        ArcadeCaseData.BuyList.m_Value.Add("Arcade1");
        InvenData.Coin.m_Value = 0;
        InvenData.Token.m_Value = 0;
        ItemData.ItemList.m_Value.ForEach(v =>
        {
            v.m_IsCollected = false;
        });
    }
}