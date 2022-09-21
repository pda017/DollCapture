using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Shuffle
{
    public static void ShuffleArray<T>(T[] array, System.Random random)
    {
        int random1;
        int random2;

        T tmp;

        for (int index = 0; index < array.Length; ++index)
        {
            random1 = random.Next(0, array.Length);
            random2 = random.Next(0, array.Length);

            tmp = array[random1];
            array[random1] = array[random2];
            array[random2] = tmp;
        }
    }

    public static void ShuffleList<T>(List<T> list, System.Random random)
    {
        if (list.Count < 2)
            return;

        int random1;
        int random2;

        T tmp;

        for (int index = 0; index < list.Count; ++index)
        {
            random1 = random.Next(0, list.Count);
            random2 = random.Next(0, list.Count);

            tmp = list[random1];
            list[random1] = list[random2];
            list[random2] = tmp;
        }
    }
    public static void ShuffleArray<T>(T[] array)
    {
        int random1;
        int random2;

        T tmp;

        for (int index = 0; index < array.Length; ++index)
        {
            random1 = Random.Range(0, array.Length);
            random2 = Random.Range(0, array.Length);

            tmp = array[random1];
            array[random1] = array[random2];
            array[random2] = tmp;
        }
    }
    public static void ShuffleList<T>(List<T> list)
    {
        if (list.Count < 2)
            return;

        int random1;
        int random2;

        T tmp;

        for (int index = 0; index < list.Count; ++index)
        {
            random1 = Random.Range(0, list.Count);
            random2 = Random.Range(0, list.Count);

            tmp = list[random1];
            list[random1] = list[random2];
            list[random2] = tmp;
        }
    }
}
