using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A
{
    private string[] week = { "월", "화", "수", "목", "금", "토", "일" };
    
    public void WriteWeek()
    {
        for (int i = 0; i < week.Length; i++)
        {
            Debug.Log(week[i]);
        }
    }

    public static int Plus(int num, int _num)
    {
        return num + _num;
    }
}

public class B : MonoBehaviour
{
    void Start()
    {
        print($"더하기는 : {A.Plus(5, 6)}");
        A a = new A();
        a.WriteWeek();
    }
}