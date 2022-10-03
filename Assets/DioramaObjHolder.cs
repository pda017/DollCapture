/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DioramaObjHolder : MonoBehaviour
{
    SpaceHouseListChanged m_SpaceHouseListChanged;
    SelectedSpaceHouseIndexChanged m_SelectedHouseIndexChanged;
    Transform m_Tf;
    State m_SceneState;
    List<GameObject> m_RemoveList = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        m_SceneState = Finder.Find<State>("PlanetDeco");
        m_SpaceHouseListChanged = new SpaceHouseListChanged();
        m_SelectedHouseIndexChanged = new SelectedSpaceHouseIndexChanged();
        m_Tf = transform;
    }
    void ClearFurniture()
    {
        m_RemoveList.Clear();
        for (int i = 0; i < m_Tf.childCount; i++)
        {
            var child = m_Tf.GetChild(i);
            m_RemoveList.Add(child.gameObject);
        }
        m_RemoveList.ForEach(v => PoolMgr.PoolDestroy(v));
    }
    // Update is called once per frame
    void Update()
    {
        if (m_SpaceHouseListChanged.Check() || m_SelectedHouseIndexChanged.Check())
        {
            var houseInfo = GetSelectedSpaceHouseInfo.Get();
            if (houseInfo != null)
            {
                ClearFurniture();
                var furnitureList = houseInfo.m_FurnitureList;
                for (int i = 0; i < furnitureList.Count; i++)
                {
                    var furnitureInfo = furnitureList[i];
                    var furnitureObj = PoolMgr.Create(furnitureInfo.m_Prefab);
                    var furnitureTf = furnitureObj.transform;
                    var furnitureIndex = furnitureObj.GetComponent<FurnitureIndex>();
                    furnitureIndex.m_Value = i;
                    furnitureTf.SetParent(m_Tf);
                    furnitureTf.position = furnitureInfo.m_Pos;
                    furnitureTf.rotation = Quaternion.Euler(furnitureInfo.m_Rot);
                }
            }
        }
    }
}
*/