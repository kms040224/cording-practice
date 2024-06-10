using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExClass2 : MonoBehaviour
{
    //������ �ۿ� ������ �ִ� ������ �⸣��

    Item sword = new Item("Sword" , 300);                                   //Item Ŭ������ Sword�� �̸��� 300�� ¥�� �������� �߰�
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

