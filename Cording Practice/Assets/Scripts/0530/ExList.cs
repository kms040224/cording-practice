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
    //List<변수형> 리스트 이름 = new List<리스트 이름>();
    //리스트 내의 요소는 접근과 수정이 가능하며 배열과는 다르게 추가 삽입 삭제를 할 수 있는 다양한 매서드가 있다.
    List<string> Skills = new List<string>()
    {
        "하이드로 펌프",
        "파도타기",
        "폭포오르기",
        "얼음엄니"

        //리스트에서 지우는 함수가 뭐였더라??  >>Remove 라고 하네요!
    };
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))         //레벨을 1레벨 올리는 치트키
        {
            LvUP();
        }
    }
}
