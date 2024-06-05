using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle : MonoBehaviour
{
    // Start is called before the first frame update

    public States currentState;                         //현재 배틀의 상태값
    public States nextState;                            //다음 상태값
    public Action action;                               //플레이어와 적의 행동
    
    void Start()
    {
        currentState = States.none;                     //Start에 초기 상태값을 아무것도 하지 않는 none 상태로 지정
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)                           //상태값에 따라 
        {
            case States.myTurn:
                MyTurn();
                break;

            case States.enemyTurn:
                EnemyTurn();
                break;

            case States.fight:
                Fight();
                break;

           
        }

    }

    public void ChangeStates()
    {
        currentState = nextState;
    }

    public void MyTurn()
    {
        switch(action)
        {


        }
    }

    public void EnemyTurn()
    {

    }

    public void Fight()
    {

    }

}

public enum States
{ 
    none,
    myTurn,
    enemyTurn,
    fight
}

public enum Action
{ 
    useItem,
    changePokemon,
    runFromWildPokemon
    

}


