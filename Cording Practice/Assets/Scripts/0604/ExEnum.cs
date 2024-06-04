using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExEnum : MonoBehaviour
{
    // enum(������) �ǽ�
    //States.XXX �� ���� ����

    public enum States              //���°� ������ �̸� ���°� ������ �̵��� �����ϸ� ¥���� ������ ����
    { 
        Idle,
        Walking,
        Running,
        Riding,
        Battle,
        Report,
        UsingBag,
        Healing

    }

    public States currentState;         //���� �÷��̾��� ���°��� �޾ƿ��� ����
    public bool isRiding = false;       //������ ž�� ����
    public float playermMoveSpd = 0;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()                                       //���°� �����ֱ�
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            currentState = States.Walking;
        }
        else if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                currentState = States.Running; ;
            }
            else
            {
                currentState = States.Walking;
            }
        }
        else if (isRiding = true && playermMoveSpd > 0 )                    //bool ���� ���� �����ؾ� �ϴ��� �����ؾ���
        {
            currentState = States.Riding;
        }
        else if(currentState == States.Battle)
        {
            playermMoveSpd = 0;
        }
        
    }
}
