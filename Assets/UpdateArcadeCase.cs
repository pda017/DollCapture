using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateArcadeCase : MonoBehaviour
{
    SpawnArcadeDoll m_SpawnArcadeDoll;
    ArcadeSelectIndexChanged m_IndexChanged;
    int m_NumState = 0;
    // Start is called before the first frame update
    void Start()
    {
        m_SpawnArcadeDoll = new SpawnArcadeDoll();
        m_IndexChanged = new ArcadeSelectIndexChanged();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_IndexChanged.Check())
        {
            var info = GetArcadeInfo.Get(ArcadeCaseData.SelectedArcadeIndex.m_Value);
            if (info != null)
            {
                ClearDolls.Set();
                DestroyAllArcade.Set();
                var obj = PrefabMgr.Create(info.m_Prefab);
                var tf = obj.transform;
                tf.position = Vector3.zero;
                tf.rotation = Quaternion.Euler(0, 180, 0);
                m_NumState = 1;
                return;    
            }
        }

        if (m_NumState == 1)
        {
            m_SpawnArcadeDoll.InitArcade();
            m_SpawnArcadeDoll.Set(8);
            m_NumState++;
        }
    }
}
