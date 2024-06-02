using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExDictionary : MonoBehaviour
{
    //딕셔너리는 단일 값이 아닌 쌍을 이루는 값을 저장한다
    //배열이나 리스트와는 달리 딕셔너리는 순서가 없다
    //Dictionary< 키 , 값  > 딕셔너리 이름 = new Dictionary<키 , 값>(); 의 형식으로 쓴다.

   

    

    //키 - 쌍 값은 클래스와 매서드를 사용해 딕셔너리에 추가,제거,엑세스를 할 수 있다.

    


    //다음 번엔 비전머신을 한번 만들어 볼거에요
    
    void Start()
    {
        Dictionary<string, int> carMembers = new Dictionary<string, int>()
    {
        { "용진" , 21 },
        {"평오" , 21 },
        {"민성", 21 },
        {"시온", 21 }

            
    };
        carMembers["평오"] = 10;                            //"평오" 의 int 값에 10을 할당하고 ageOfCarMembers를 콘솔에 출력하면 10이 나온다

        int ageOfCarMembers = carMembers["평오"];           //변수 ageOfCarMembers에 int 값 21을 할당
        Debug.Log(ageOfCarMembers);

        carMembers.Add("정민", 21);
        Debug.Log(carMembers);

        if(carMembers.Count == 5)
        {
            Debug.Log("오늘은 정민이가 차에 탔어요");
        }
        
        //딕셔너리와 함께 쓰이는 매서드 Add:항목 더해줌 , Remove:항목 없에줌, ContainsKey: 키의 유무 여부에 따라 bool 값을 반환함
        //이때 ContainsKey 매서드는 if 문과 같이 사용됨

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
