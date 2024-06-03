using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    // 턴을 관리할 턴 매니저

    public static TurnManager instance;                     //싱글톤을 할당할 전역 변수 선언
    public bool battleStart = false;                        //전투 시작 여부를 체크하는 변수
    public bool isDefeat = false;                           //패배 상태
    public bool isGotcha = false;                           //야생 포켓몬을 잡았을때
    public bool isWin = false;                              //플레이어를 상대로 이겼을때 혹은 야생 포켓몬을 잡았을때
    public bool isMyTurnEnd = false;                        //자신의 턴이 종료 되었는가

    public int actionPoint = 1;                             //행동 횟수
    public int exp = 0;                                     //야생 포켓몬을 처치 하거나 배틀에서 npc에게 승리하였을 때 지급되는 경험치

    private void Awake()
    {
        if (instance == null)                               //instance가 비어있다면
        {
            instance = this;                                //그곳에 자신을 할당
        }
        else
        {
            Debug.Log("씬에 두개 이상의 턴 매니저가 존재합니다");
            Destroy(gameObject);
        }
    }

    public void lostMoney()
    {
       if (isDefeat == true)
        {

        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
