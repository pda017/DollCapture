using System.Collections;
using UnityEngine;

public class SpawnArcadeDoll
{
    RandomSpawnPos m_RandomSpawnPos;
    GetRandomArcadeDoll m_GetRandomArcadeDoll;
    public SpawnArcadeDoll()
    {
        m_GetRandomArcadeDoll = new GetRandomArcadeDoll();
        m_RandomSpawnPos = new RandomSpawnPos();
        m_GetRandomArcadeDoll.SetArcade("Arcade1");
    }
    public void Set(int num)
    {
        for (int i = 0; i < num; i++)
        {
            var posTf = m_RandomSpawnPos.GetTf();
            var obj = PrefabMgr.Create("BaseChar");
            var itemKey = obj.GetComponent<ItemKey>();
            var itemInfo = m_GetRandomArcadeDoll.Get();
            var charParts = obj.GetComponentInChildren<CharParts>();
            CharPartsCopy.Set(itemInfo.m_CharParts, charParts.m_Value);
            charParts.m_Dirty++;
            itemKey.m_Value = itemInfo.m_Key;
            itemKey.m_Dirty++;
            var tf = obj.transform;
            tf.position = posTf.position;
            tf.rotation = posTf.rotation;
            var pose = obj.GetComponentInChildren<CharPose>();
            pose.m_Value = itemInfo.m_Pose;
            pose.m_Dirty++;
        }
    }
}