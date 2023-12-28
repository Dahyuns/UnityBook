using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldTest : MonoBehaviour
{
    void Start()
    {
        int[] ints = { -2, -5, -3, -7, -1 };
        int max = int.MinValue;
        for (int i = 0; i < ints.Length; i++)
        {
            if (ints[i] > max)
            {
                max = ints[i];
            }
        }
        print($@"ÃÖ´ñ°ª: {max}");
    }
}
