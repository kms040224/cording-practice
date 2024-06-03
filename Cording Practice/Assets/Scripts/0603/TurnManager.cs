using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    // ���� ������ �� �Ŵ���

    public static TurnManager instance;                     //�̱����� �Ҵ��� ���� ���� ����
    public bool battleStart = false;                        //���� ���� ���θ� üũ�ϴ� ����
    public bool isDefeat = false;                           //�й� ����
    public bool isGotcha = false;                           //�߻� ���ϸ��� �������
    public bool isWin = false;                              //�÷��̾ ���� �̰����� Ȥ�� �߻� ���ϸ��� �������
    public bool isMyTurnEnd = false;                        //�ڽ��� ���� ���� �Ǿ��°�

    public int actionPoint = 1;                             //�ൿ Ƚ��
    public int exp = 0;                                     //�߻� ���ϸ��� óġ �ϰų� ��Ʋ���� npc���� �¸��Ͽ��� �� ���޵Ǵ� ����ġ

    private void Awake()
    {
        if (instance == null)                               //instance�� ����ִٸ�
        {
            instance = this;                                //�װ��� �ڽ��� �Ҵ�
        }
        else
        {
            Debug.Log("���� �ΰ� �̻��� �� �Ŵ����� �����մϴ�");
            Destroy(gameObject);
        }
    }

    public void lostMoney()
    {
       if (isDefeat == true)
        {

        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
