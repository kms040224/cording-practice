using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExEnum : MonoBehaviour
{
    // enum(열거형) 실습
    //States.XXX 로 접근 가능

    public enum States              //상태값 나눌때 미리 상태값 사이의 이동을 생각하며 짜보는 습관이 좋음
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

    public States currentState;         //현재 플레이어의 상태값을 받아오는 변수
    public bool isRiding = false;       //자전거 탑승 여부
    public float playermMoveSpd = 0;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()                                       //상태값 나눠주기
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
        else if (isRiding = true && playermMoveSpd > 0 )                    //bool 값을 따로 지정해야 하는지 질문해야함
        {
            currentState = States.Riding;
        }
        else if(currentState == States.Battle)
        {
            playermMoveSpd = 0;
        }
        
    }
}
