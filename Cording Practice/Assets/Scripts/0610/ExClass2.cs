using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExClass2 : MonoBehaviour
{
    //변수는 밖에 선언해 주는 습관을 기르자

    Item sword = new Item("Sword" , 300);                                   //Item 클래스에 Sword란 이름의 300원 짜리 아이템을 추가
    Item woodShield = new Item("WoodShield", 350);
    void Start()
    {
        PrintItemInfo();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PrintItemInfo()
    {
        Debug.LogFormat("{0}:{1} GOLD", sword.name, sword.cost);
        Debug.LogFormat("{0}:{1} GOLD", woodShield.name, woodShield.cost);
    }
}

public class Item
{
    public string name;
    public int cost;

    public Item(string name , int cost)
    {
        this.name = name;
        this.cost = cost;
    }
}

