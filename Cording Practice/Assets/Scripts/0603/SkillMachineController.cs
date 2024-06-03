using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillMachineController : MonoBehaviour
{
    // 딕셔너리로 기술머신 만들어 보기

    Dictionary<int, SkillMachine> skillMachines = new Dictionary<int, SkillMachine>();              //딕셔너리 생성

    
    void Start()
    {
        var tempSkill = new SkillMachine(1, "손톱 갈기", 15, 0);                        //클래스의 값을 가져올 변수를 임시 생성
        skillMachines.Add(tempSkill.skillNum, tempSkill);                               //딕셔너리는 Add 매서드를 통해 값을 집어넣으세요
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class SkillMachine                                   //굳이 스크립트 생성할때 생기는 클래스 안에 안넣어도 됨
{
    public int skillNum = 0;
    public string skillName = "";
    public int skillPoint = 0;
    public int skillDamage = 0;
    public SkillMachine(int _skillNum, string _skillName, int _skillPoint, int _skillDamage)                    //사용할 변수 형식 선언
    {
        this.skillNum = _skillNum;                      //this. 을 이용하여 스킬 고유의 값을 받아올 변수를 선언 뒤 원래 변수의 값을 초기화
        this.skillName = _skillName;
        this.skillPoint = _skillPoint;
        this.skillDamage = _skillDamage;
    }
}
