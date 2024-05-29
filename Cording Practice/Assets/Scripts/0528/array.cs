using System.Collections.Generic;
using UnityEngine;
public class Array : MonoBehaviour
{
    public List<string> gameNames = new List<string>();
    void Start()
    {
        DataReset();
    }
    public void DataReset()                                 //gameNames 안에 .Add를 사용하여 값을 넣어줌
    {
        Debug.Log("Reset!");
        gameNames.Clear();
        gameNames.Add("원신");
        gameNames.Add("붕괴 스타레일");
        gameNames.Add("블루 아카이브");
        gameNames.Add("롤");
    }
    public string poTodaysGame()
    {
        if (gameNames.Count <= 0)                           //리스트 안에 데이터 값을 넣어줌
            DataReset();

        var random = Random.Range(0, gameNames.Count);      //var 변수형으로 랜덤값을 만듦
        var name = gameNames[random];                       //Random.range를 사용하여 나온 랜덤값에 해당하는 값의 이름을 name 변수에 저장
        gameNames.Remove(gameNames[random]);                //해당하는 값이 출력될때 Remove를 사용하여 리스트 내의 값을 제거

        return name;                                        //name 값을 출력
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))                 //스페이스바를 누를때
        {
            Debug.Log(poTodaysGame());                       //콘솔창에 오늘의 평오가 할 게임을 출력
        }
    }
}