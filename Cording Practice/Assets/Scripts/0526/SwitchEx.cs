using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchEx : MonoBehaviour
{
    public string JungminAction = "Attack";         //JungminAction �̶�� ���ο� string ���� �����ϰ� "Attack" ���� �־��ش�.
                                                    //switch ���� case�� ������ ���� �ڿ� �ݷ��� ���� ex)case "hit":~~~ \              
                                                    //Default:�� ��� ������ ���� �ؾ���

    public void PrintAction()
    {
        switch(JungminAction)
        {
            case "eat":
                Debug.Log("�����̰� ���� �Ծ��");
                break;

            case "kfc":
                Debug.Log("�����̰� KFC�� �ֹ��ؿ�");
                break;

            case "Attack":
                Debug.Log("�����̰� ���޻� ���̸� ������");
                break;

        }
    }

    public void DiceNum()       //���� ���� ���� ����� �ǽ�
    {
        int diceNum = Random.Range(1, 7);             //integer ���� �� random �Լ� �̿� �̶� Random.range�� ��ȣ �� ���� (���� ����,������ ���� +1)

        switch (diceNum)
        {
            case 1:
                Debug.Log("���� 1");
                break;

            case 2:
                Debug.Log("���� 2");
                break;

            case 3:
                Debug.Log("���� 3");
                break;

            case 4:
                Debug.Log("���� 4");
                break;

            case 5:
                Debug.Log("���� 5");
                break;

            case 6:
                Debug.Log("���� 6");
                break;
        }
    }
    
    void Start()
    {   //����ġ�� �⺻ ���� ����
        if(Input.GetKeyDown(KeyCode.Space))
        {
            DiceNum();
        }
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
