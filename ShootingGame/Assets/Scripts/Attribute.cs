using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Attribute
{
    //여러 기능이 많이 있는데 그중 하나가
    //obsolete, (메세지와 함께)경고해줌. 클래스, 함수, 변수 가능  

    [Obsolete("Using Other Class")]
    public class Dog
    {
        [Obsolete("Using New Member Method")]
        public void OldMember()
        {
            Debug.Log("(오래된)먹다");
        }

        [Obsolete("쓰지말라")]
        public int intnum;

        public void NewMember()
        {
            Debug.Log("(새로운)먹다");
        }
    }



    public class Attribute : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {/*
            Dog dog = new Dog();
            dog.OldMember();
            dog.NewMember();
            dog.intnum = 20;*/
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}