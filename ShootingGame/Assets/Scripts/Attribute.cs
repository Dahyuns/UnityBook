using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Attribute
{
    //���� ����� ���� �ִµ� ���� �ϳ���
    //obsolete, (�޼����� �Բ�)�������. Ŭ����, �Լ�, ���� ����  

    [Obsolete("Using Other Class")]
    public class Dog
    {
        [Obsolete("Using New Member Method")]
        public void OldMember()
        {
            Debug.Log("(������)�Դ�");
        }

        [Obsolete("��������")]
        public int intnum;

        public void NewMember()
        {
            Debug.Log("(���ο�)�Դ�");
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