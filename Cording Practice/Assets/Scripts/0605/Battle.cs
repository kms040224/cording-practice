using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle : MonoBehaviour
{
    // Start is called before the first frame update

    public States currentState;                         //���� ��Ʋ�� ���°�
    public States nextState;                            //���� ���°�
    public Action action;

    public SkillInfo skillInfo;                          //��ų�� ������ ����
    public PokemonInfo pokemonInfo;                     //���ϸ� ������ ������ ����

    

    
    //�÷��̾�� ���� �ൿ
    
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
    public string pokemonType1 = "";            //Ÿ��1
    public string pokemonType2 = "";            //Ÿ��2
    public int h = 0;                       //HP
    public int a = 0;                       //����
    public int d = 0;                       //����
    public int sa = 0;                       //Ư��
    public int sd = 0;                       //Ư��
    public int spd = 0;                       //���ǵ�

    public void Mimikyu(string _pokemonType1 = "��Ʈ" , string _pokemonType2 = "��" , int _h = 55 , int _a =90, int _d = 80 , int _sa = 50 , int _sd = 105  , int _spd = 96 )                               //�� ����ť��
    {

        this.h = _h;
        this.a = _a;
        this.d = _d;
        this.sa = _sa;
        this.sd = _sd;
        this.spd = _spd;

        Dictionary<SkillInfo, string> skills = new Dictionary<SkillInfo, string>();                         //��ų�� �־��� ��ųʸ�

        



    }
}




public class SkillInfo                      //��ų�� ������ �ִ� �� => SkillMachineController �� Ȯ���ϸ� �� �� ���� / �ϴ� ���ݽ�ų�� ����� ����
{
    public string type = "";
    public int pp = 0;
    public int hitRate = 0;
    public int damage = 0;

    public void ShadowSneak(string _type = "��Ʈ", int _pp = 30 , int _hitRate = 100 , int _damage = 40 )        //�߽�
    {
        this.type = _type;
        this.pp = _pp;
        this.hitRate = _hitRate;
        this.damage = _damage;

        
    }

    public void ShadowClaw(string _type = "��Ʈ", int _pp = 15, int _hitRate = 100, int _damage = 70)    //����ũ��
    {
        this.type = _type;
        this.pp = _pp;
        this.hitRate = _hitRate;
        this.damage = _damage;

    }

    public void PlayRough(string _type = "��", int _pp = 10, int _hitRate = 90, int _damage = 90)      //ġ�ٰŸ���
    {
        this.type = _type;
        this.pp = _pp;
        this.hitRate = _hitRate;
        this.damage = _damage;
    }

}








