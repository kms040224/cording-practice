using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ExForeach : MonoBehaviour
{
    //foreach문은 컬렉션의 각 요소를 가져온 후 지역변수에 저장해 구문 내에서 엑세스 하는 역할
    //배열과 리스트 딕셔너리에 사용 가능하다.
    //foreach(변수형 저장할 지역변수 이름 in 저장공간 이름)으로 짜여진다.

    List<string> skills = new List<string>();

    Dictionary<string, int> pokemons = new Dictionary<string, int>
    {
        {"피카츄" , 50 },
        {"핑복" , 12 },
        {"마임맨" , 30 },
        {"메꾸리" , 21 },
        {"몰드류" , 63  },
        {"개구마르" , 8 }

    };


    void Start()
    {
        //AddSkill();
    }



    public void AddSkill()
    {
        skills.Add("꼬리흔들기");
        skills.Add("모래뿌리기");
        skills.Add("독압정");
        skills.Add("리플렉터");
    }

    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        { 
            foreach( KeyValuePair< string , int > pokemon in pokemons )                                //딕셔너리는 키-쌍값을 KeyValuePair< string , int > 형식으로 불러옴
            {
                if(pokemon.Value <= 50)                                                                 //레벨이 50보다 작은 친구들은 레벨을 50으로 조정
                {
                    int level = pokemon.Value;                                                          //레벨을 조정하기 위해 변수 하나 선언
                    string name = pokemon.Key;
                    level = 50;                                                                         //Value 값을 50으로 조정

                    Debug.Log(name + ":" + level);
                }
                else
                {
                    Debug.Log(pokemon.Key + "의 레벨이 너무 높아요");
                }
            }
        }
    }
}
