using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diorama_BackButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ButtonEvent.AddClickEvent(gameObject, () =>
        {
            SceneMgr.LoadScene("GameScene");
        });
    }
}
