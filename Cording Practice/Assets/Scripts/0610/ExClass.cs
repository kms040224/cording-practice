using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExClass : MonoBehaviour
{
    public Dictionary<int, MyPokemon> poekmonDictionary = new Dictionary<int, MyPokemon>();                         //딕셔너리 선언
    

    void Start()
    {
        poekmonDictionary.Add(1, new MyPokemon(1, "제르네아스", 50));                            //포켓몬 넣어주기
        poekmonDictionary.Add(2, new MyPokemon(2, "개굴닌자", 50));
        poekmonDictionary.Add(3, new MyPokemon(3, "가디안", 50));
        poekmonDictionary.Add(4, new MyPokemon(4, "파이어로", 50));
        poekmonDictionary.Add(5, new MyPokemon(5, "루카리오", 50));
        poekmonDictionary.Add(6, new MyPokemon(6, "드래캄", 50));

    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Space))                                                             //콘솔에 출력
        {
            for(int i = 1; i <= 6;  i++)
            {
                Debug.Log(poekmonDictionary[i].indexNum + "번째 포켓몬"+ ":" + poekmonDictionary[i].name + "lv"  + poekmonDictionary[i].lv);
            }
        }
    }
}

public class MyPokemon                                                                                  //인덱스 넘버를 int로 지정하면 찾는데 수월함
{
    public int indexNum;
    public string name;
    public int lv;

    public MyPokemon(int indexNum, string name, int level)                                              //변수를 초기화
    {
        this.indexNum = indexNum;
        this.name = name;
        this.lv = level;
    }

    
}

















