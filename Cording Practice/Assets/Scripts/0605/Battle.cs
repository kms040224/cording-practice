using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle : MonoBehaviour
{
    // Start is called before the first frame update

    public States currentState;                         //���� ��Ʋ�� ���°�
    public States nextState;                            //���� ���°�
    public Action action;                               //�÷��̾�� ���� �ൿ
    
    void Start()
    {
        currentState = States.none;                     //Start�� �ʱ� ���°��� �ƹ��͵� ���� �ʴ� none ���·� ����
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)                           //���°��� ���� 
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


