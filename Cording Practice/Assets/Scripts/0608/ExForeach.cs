using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ExForeach : MonoBehaviour
{
    //foreach���� �÷����� �� ��Ҹ� ������ �� ���������� ������ ���� ������ ������ �ϴ� ����
    //�迭�� ����Ʈ ��ųʸ��� ��� �����ϴ�.
    //foreach(������ ������ �������� �̸� in ������� �̸�)���� ¥������.

    List<string> skills = new List<string>();

    Dictionary<string, int> pokemons = new Dictionary<string, int>
    {
        {"��ī��" , 50 },
        {"�κ�" , 12 },
        {"���Ӹ�" , 30 },
        {"�޲ٸ�" , 21 },
        {"�����" , 63  },
        {"��������" , 8 }

    };


    void Start()
    {
        //AddSkill();
    }



    public void AddSkill()
    {
        skills.Add("��������");
        skills.Add("�𷡻Ѹ���");
        skills.Add("������");
        skills.Add("���÷���");
    }

    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        { 
            foreach( KeyValuePair< string , int > pokemon in pokemons )                                //��ųʸ��� Ű-�ְ��� KeyValuePair< string , int > �������� �ҷ���
            {
                if(pokemon.Value <= 50)                                                                 //������ 50���� ���� ģ������ ������ 50���� ����
                {
                    int level = pokemon.Value;                                                          //������ �����ϱ� ���� ���� �ϳ� ����
                    string name = pokemon.Key;
                    level = 50;                                                                         //Value ���� 50���� ����

                    Debug.Log(name + ":" + level);
                }
                else
                {
                    Debug.Log(pokemon.Key + "�� ������ �ʹ� ���ƿ�");
                }
            }
        }
    }
}
