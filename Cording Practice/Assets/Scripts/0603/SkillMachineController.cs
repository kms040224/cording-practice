using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillMachineController : MonoBehaviour
{
    // ��ųʸ��� ����ӽ� ����� ����

    Dictionary<int, SkillMachine> skillMachines = new Dictionary<int, SkillMachine>();              //��ųʸ� ����

    
    void Start()
    {
        var tempSkill = new SkillMachine(1, "���� ����", 15, 0);                        //Ŭ������ ���� ������ ������ �ӽ� ����
        skillMachines.Add(tempSkill.skillNum, tempSkill);                               //��ųʸ��� Add �ż��带 ���� ���� �����������
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class SkillMachine                                   //���� ��ũ��Ʈ �����Ҷ� ����� Ŭ���� �ȿ� �ȳ־ ��
{
    public int skillNum = 0;
    public string skillName = "";
    public int skillPoint = 0;
    public int skillDamage = 0;
    public SkillMachine(int _skillNum, string _skillName, int _skillPoint, int _skillDamage)                    //����� ���� ���� ����
    {
        this.skillNum = _skillNum;                      //this. �� �̿��Ͽ� ��ų ������ ���� �޾ƿ� ������ ���� �� ���� ������ ���� �ʱ�ȭ
        this.skillName = _skillName;
        this.skillPoint = _skillPoint;
        this.skillDamage = _skillDamage;
    }
}
