using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRandom : MonoBehaviour
{
    void Start()
    {
        WriteRandom();
    }

    static void WriteRandom()
    {
        List<int> RNums = new List<int> { };

        for (int i = 0; i < 6; i++)
        {
            int newNum;
            do
            {
                newNum = Random.Range(1, 45);
            } while (RNums.Contains(newNum));
            RNums.Add(newNum);
        }

        foreach (int i in RNums)
        {
            Debug.Log(i);
        }
    }
}