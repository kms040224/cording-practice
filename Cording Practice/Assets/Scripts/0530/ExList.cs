using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExList : MonoBehaviour
{

    public int characterLv = 50;

    public void LvUP()
    {
            characterLv++;
        
    }
    //List<������> ����Ʈ �̸� = new List<����Ʈ �̸�>();
    //����Ʈ ���� ��Ҵ� ���ٰ� ������ �����ϸ� �迭���� �ٸ��� �߰� ���� ������ �� �� �ִ� �پ��� �ż��尡 �ִ�.
    List<string> Skills = new List<string>()
    {
        "���̵�� ����",
        "�ĵ�Ÿ��",
        "����������",
        "��������"

        //����Ʈ���� ����� �Լ��� ��������??  >>Remove ��� �ϳ׿�!
    };
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))         //������ 1���� �ø��� ġƮŰ
        {
            LvUP();
        }
    }
}
