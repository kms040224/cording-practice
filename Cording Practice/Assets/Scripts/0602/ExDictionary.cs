using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExDictionary : MonoBehaviour
{
    //��ųʸ��� ���� ���� �ƴ� ���� �̷�� ���� �����Ѵ�
    //�迭�̳� ����Ʈ�ʹ� �޸� ��ųʸ��� ������ ����
    //Dictionary< Ű , ��  > ��ųʸ� �̸� = new Dictionary<Ű , ��>(); �� �������� ����.

   

    

    //Ű - �� ���� Ŭ������ �ż��带 ����� ��ųʸ��� �߰�,����,�������� �� �� �ִ�.

    


    //���� ���� �����ӽ��� �ѹ� ����� ���ſ���
    
    void Start()
    {
        Dictionary<string, int> carMembers = new Dictionary<string, int>()
    {
        { "����" , 21 },
        {"���" , 21 },
        {"�μ�", 21 },
        {"�ÿ�", 21 }

            
    };
        carMembers["���"] = 10;                            //"���" �� int ���� 10�� �Ҵ��ϰ� ageOfCarMembers�� �ֿܼ� ����ϸ� 10�� ���´�

        int ageOfCarMembers = carMembers["���"];           //���� ageOfCarMembers�� int �� 21�� �Ҵ�
        Debug.Log(ageOfCarMembers);

        carMembers.Add("����", 21);
        Debug.Log(carMembers);

        if(carMembers.Count == 5)
        {
            Debug.Log("������ �����̰� ���� �����");
        }
        
        //��ųʸ��� �Բ� ���̴� �ż��� Add:�׸� ������ , Remove:�׸� ������, ContainsKey: Ű�� ���� ���ο� ���� bool ���� ��ȯ��
        //�̶� ContainsKey �ż���� if ���� ���� ����

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
