using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchEx : MonoBehaviour
{
    public string JungminAction = "Attack";         //JungminAction 이라는 새로운 string 값을 선언하고 "Attack" 값을 넣어준다.
                                                    //switch 문은 case를 나누고 나서 뒤에 콜론을 붙임 ex)case "hit":~~~ \              
                                                    //Default:는 어떨때 쓰는지 질문 해야함

    public void PrintAction()
    {
        switch(JungminAction)
        {
            case "eat":
                Debug.Log("정민이가 밥을 먹어요");
                break;

            case "kfc":
                Debug.Log("정민이가 KFC를 주문해요");
                break;

            case "Attack":
                Debug.Log("정민이가 동급생 아이를 때려요");
                break;

        }
    }

    public void DiceNum()       //랜덤 값을 같이 사용한 실습
    {
        int diceNum = Random.Range(1, 7);             //integer 선언 후 random 함수 이용 이때 Random.range의 괄호 내 값은 (시작 숫자,마지막 숫자 +1)

        switch (diceNum)
        {
            case 1:
                Debug.Log("숫자 1");
                break;

            case 2:
                Debug.Log("숫자 2");
                break;

            case 3:
                Debug.Log("숫자 3");
                break;

            case 4:
                Debug.Log("숫자 4");
                break;

            case 5:
                Debug.Log("숫자 5");
                break;

            case 6:
                Debug.Log("숫자 6");
                break;
        }
    }
    
    void Start()
    {   //스위치문 기본 구조 예제
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
