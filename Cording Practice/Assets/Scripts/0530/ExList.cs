using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExList : MonoBehaviour
{

    public int characterLv = 50;
    public string hydroCanon = "���̵�� ĳ��";
    public bool learnSkill = false;                         //���� ������ ��,��ų ������,��ų ���� ���� ���°��� ���� �������ָ� ���Ұ� ����

    public void LvUP()
    {
            characterLv++;
        
    }
    //List<������> ����Ʈ �̸� = new List<����Ʈ �̸�>();
    //����Ʈ ���� ��Ҵ� ���ٰ� ������ �����ϸ� �迭���� �ٸ��� �߰� ���� ������ �� �� �ִ� �پ��� �ż��尡 �ִ�.

    List<string> Skills = new List<string>()                //���߿� ��ų���� ������ ���� ���ϰ� ������ ����
    {
        "���̵�� ����",
        "�ĵ�Ÿ��",
        "����������",
        "��������"

        
    };

    public void LearnHydroCanon()
    {

        if (Skills.Count == 4)
        {
            Debug.Log("�׷��� ���������� �̹� 4���� ����� ���� �ִ�");
            Debug.Log("���������� ����� �ذ� �Ͻðڽ��ϱ�?");


            if (Input.GetKeyDown(KeyCode.Y))
            {   
                Skills.Remove("��������");                                  //����Ʈ ���� �׸��� �����ϴ� �Լ�
                Debug.Log("���������� �������ϸ� ������ �ؾ���");
                Skills.Add(hydroCanon);                                     //����Ʈ ���� �׸��� �߰��ϴ� �Լ�
                Debug.Log("�׸��� ���������� ���̵�� ĳ���� ���� �����.");

            }
            else if (Input.GetKeyDown(KeyCode.N))                //�������� : GetKeyDown�� �����Ͽ� ����Ű�� �ι� ����� �� ������ �Ǵ°�?
            {
                Debug.Log("���������� �ᱼ ���̵�� ĳ���� ����� �ʾҴ�.");
            }


        }
    }
        
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))         //������ 1���� �ø��� ġƮŰ
        {
            LvUP();
        }


        if(characterLv == 51)                                               //���� �����ҰԿ�;;
        {
            Debug.Log("���������� 51������ �Ǿ���");
            Debug.Log("���������� ���̵�� ĳ���� ��� �� �ִ�.");
            
        }
        

    }
}
