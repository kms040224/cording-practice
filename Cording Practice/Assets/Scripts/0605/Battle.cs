using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle : MonoBehaviour
{
    // Start is called before the first frame update

    public States currentState;                         //현재 배틀의 상태값
    public States nextState;                            //다음 상태값
    public Action action;

    public SkillInfo skillInfo;                          //스킬을 가져올 변수
    public PokemonInfo pokemonInfo;                     //포켓몬 정보를 가져올 변수

    

    
    //플레이어와 적의 행동
    
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
        int useSkill = Random.Range(0, 3);

    }

    public void EnemyTurn()
    {
        int useSkill = Random.Range(0, 3);
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
    runFromWildPokemon,
    useSkill


}

public class PokemonInfo
{
    public string pokemonType1 = "";            //타입1
    public string pokemonType2 = "";            //타입2
    public int h = 0;                       //HP
    public int a = 0;                       //물공
    public int d = 0;                       //물방
    public int sa = 0;                       //특공
    public int sd = 0;                       //특방
    public int spd = 0;                       //스피드

    public void Mimikyu(string _pokemonType1 = "고스트" , string _pokemonType2 = "페어리" , int _h = 55 , int _a =90, int _d = 80 , int _sa = 50 , int _sd = 105  , int _spd = 96 )                               //얘 따라큐임
    {

        this.h = _h;
        this.a = _a;
        this.d = _d;
        this.sa = _sa;
        this.sd = _sd;
        this.spd = _spd;

        Dictionary<SkillInfo, string> skills = new Dictionary<SkillInfo, string>();                         //스킬을 넣어줄 딕셔너리

        



    }
}




public class SkillInfo                      //스킬이 가지고 있는 값 => SkillMachineController 를 확인하면 알 수 있음 / 일단 공격스킬만 만들어 보자
{
    public string type = "";
    public int pp = 0;
    public int hitRate = 0;
    public int damage = 0;

    public void ShadowSneak(string _type = "고스트", int _pp = 30 , int _hitRate = 100 , int _damage = 40 )        //야습
    {
        this.type = _type;
        this.pp = _pp;
        this.hitRate = _hitRate;
        this.damage = _damage;

        
    }

    public void ShadowClaw(string _type = "고스트", int _pp = 15, int _hitRate = 100, int _damage = 70)    //섀도크루
    {
        this.type = _type;
        this.pp = _pp;
        this.hitRate = _hitRate;
        this.damage = _damage;

    }

    public void PlayRough(string _type = "페어리", int _pp = 10, int _hitRate = 90, int _damage = 90)      //치근거리기
    {
        this.type = _type;
        this.pp = _pp;
        this.hitRate = _hitRate;
        this.damage = _damage;
    }

}








