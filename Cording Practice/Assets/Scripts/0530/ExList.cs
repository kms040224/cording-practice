using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExList : MonoBehaviour
{

    public int characterLv = 50;
    public string hydroCanon = "하이드로 캐논";
    public bool learnSkill = false;                         //레벨 오르는 중,스킬 선택중,스킬 삭제 때의 상태값을 따로 지정해주면 편할거 같음

    public void LvUP()
    {
            characterLv++;
        
    }
    //List<변수형> 리스트 이름 = new List<리스트 이름>();
    //리스트 내의 요소는 접근과 수정이 가능하며 배열과는 다르게 추가 삽입 삭제를 할 수 있는 다양한 매서드가 있다.

    List<string> Skills = new List<string>()                //나중에 스킬들을 변수로 만들어서 편하게 관리할 에정
    {
        "하이드로 펌프",
        "파도타기",
        "폭포오르기",
        "얼음엄니"

        
    };

    public void LearnHydroCanon()
    {

        if (Skills.Count == 4)
        {
            Debug.Log("그러나 김김평평오는 이미 4개의 기술을 배우고 있다");
            Debug.Log("김김평평오의 기술을 잊게 하시겠습니까?");


            if (Input.GetKeyDown(KeyCode.Y))
            {   
                Skills.Remove("얼음엄니");                                  //리스트 내의 항목을 제거하는 함수
                Debug.Log("김김평평오는 얼음엄니를 깨끗이 잊었다");
                Skills.Add(hydroCanon);                                     //리스트 내에 항목을 추가하는 함수
                Debug.Log("그리고 김김평평오는 하이드로 캐논을 새로 배웠다.");

            }
            else if (Input.GetKeyDown(KeyCode.N))                //질문사항 : GetKeyDown에 관련하여 같은키를 두번 사용할 때 문제가 되는가?
            {
                Debug.Log("김김평평오는 결굴 하이드로 캐논을 배우지 않았다.");
            }


        }
    }
        
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))         //레벨을 1레벨 올리는 치트키
        {
            LvUP();
        }


        if(characterLv == 51)                                               //내일 수정할게요;;
        {
            Debug.Log("김김평평오는 51레벨이 되었다");
            Debug.Log("김김평평오는 하이드로 캐논을 배울 수 있다.");
            
        }
        

    }
}
