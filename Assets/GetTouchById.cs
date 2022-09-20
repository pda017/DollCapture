using System.Collections;
using UnityEngine;

public class GetTouchById
{
    public static bool Get(int id,out Touch value)
    {
        int touchCount = Input.touchCount;
        for (int i = 0; i < touchCount; i++)
        {
            var touch = Input.GetTouch(i);
            if (touch.fingerId == id)
            {
                value = touch;
                return true;
            }
        }
        value = default;
        return false; 
    }
}