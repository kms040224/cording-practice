using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExClass : MonoBehaviour
{
    public Dictionary<int, MyPokemon> poekmonDictionary = new Dictionary<int, MyPokemon>();                         //��ųʸ� ����
    

    void Start()
    {
        poekmonDictionary.Add(1, new MyPokemon(1, "�����׾ƽ�", 50));                            //���ϸ� �־��ֱ�
        poekmonDictionary.Add(2, new MyPokemon(2, "��������", 50));
        poekmonDictionary.Add(3, new MyPokemon(3, "�����", 50));
        poekmonDictionary.Add(4, new MyPokemon(4, "���̾��", 50));
        poekmonDictionary.Add(5, new MyPokemon(5, "��ī����", 50));
        poekmonDictionary.Add(6, new MyPokemon(6, "�巡į", 50));

    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Space))                                                             //�ֿܼ� ���
        {
            for(int i = 1; i <= 6;  i++)
            {
                Debug.Log(poekmonDictionary[i].indexNum + "��° ���ϸ�"+ ":" + poekmonDictionary[i].name + "lv"  + poekmonDictionary[i].lv);
            }
        }
    }
}

public class MyPokemon                                                                                  //�ε��� �ѹ��� int�� �����ϸ� ã�µ� ������
{
    public int indexNum;
    public string name;
    public int lv;

    public MyPokemon(int indexNum, string name, int level)                                              //������ �ʱ�ȭ
    {
        this.indexNum = indexNum;
        this.name = name;
        this.lv = level;
    }

    
}

















