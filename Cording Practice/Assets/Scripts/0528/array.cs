using OpenCover.Framework.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array : MonoBehaviour
{
    class Games
    {
        public string gameName;
        public bool isPicked;

        public void Genshin()
        {
            gameName = "원신";
            isPicked = false;
        }
        
        public void HonkaiStarRail()
        {
            gameName = "붕괴 스타레일";
            isPicked = false;
        }

        public void BlueArchive()
        {
            gameName = "블루 아카이브";
            isPicked = false;
        }

        public void LOL()
        {
            gameName = "롤";
            isPicked = false;
        }
            
    }
    //배열은 모든 타입의 값을 저장 가능(이때 모든 요소는 동일한 타입)
    //배열을 생성 시 길이나 요소의 개수를 설정 가능 (추후에 변경이 불가능하다(?))
    //배열을 생성할 때 초기값을 지정하지 않으면 기본값이 지정된다. integer와 같은 숫자 변수형의 경우에는 0으로 자동 설정되고 다른 타입은 null값이나 미설정 상태가 된다.

    void Start()
    {
        // *배열 생성시 필요한것 -> 요소의 타입(변수형 등) 과 대괄호 쌍,고유한 이름이 필요하다.
        //new 키워드의 경우 메모리에 배열을 생성하는 데 사용되며 값 타입과 대괄호 쌍이 뒤에 따라온다.배열이 저장할 요소의 개수는 두번째 대괄호 쌍 안에 들어간다.

        //일반 초기화
        //string[] poFavoriteGame = new string[] { "원신", "붕괴 스타레일", "블루 아카이브","롤" };

        //단축 초기화
        //string[] poFavoriteGame = { "원신", "붕괴 스타레일", "블루 아카이브","롤" };

       
    }

    public void poTodaysGame()
    {

        Games games = new Games();              //질문이 필요해요

        games.Genshin();
        games.HonkaiStarRail();
        games.BlueArchive();
        games.LOL();

        string _gameName = GetComponent<Games>().gameName;
        bool _isPicked = GetComponent<Games>().isPicked;
        
        string[] poTodayGame = new string[] {"원신" , "붕괴 스타레일" , "블루 아카이브" , "롤"};
        int randomNum = Random.Range(0, 4);

        if(_gameName == poTodayGame[randomNum] && )
        {

        }
        
        
        Debug.Log("오늘의 게임은 : " + poTodayGame[randomNum]);

        //전에 나왔던거 안나오게 바꿔볼 것

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            poTodaysGame();
        }
        
        
    }
}
