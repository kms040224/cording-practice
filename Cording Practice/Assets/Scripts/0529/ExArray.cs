using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExArray : MonoBehaviour
{
    public string[] poComboAttack = new string[] { "��" , "��" , "����" , "������ ���ϵ���̹�" };
    public int skillNum;
    public string _skill;
    public int usingCount = 0;


    public void FirstAttack()
    {
        skillNum = Random.Range(0, poComboAttack.Length);
        Debug.Log("������� ù��° ������" + poComboAttack[skillNum]);
        _Skill();
        usingCount++;
        skillNum = Random.Range(0, poComboAttack.Length);
    }
    public void ComboAttack()
    {
        Debug.Log("�޺�����!");
        usingCount = 0;
    }
    void Start()
    {
        
    }
    public void _Skill()
    {
         _skill = poComboAttack[skillNum];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(usingCount == 0)
            {
                FirstAttack();
            }
            else if(usingCount >= 1)
            {
                if(_skill == poComboAttack[skillNum])
                {
                    ComboAttack();
                }
                else
                {
                    usingCount = 0;
                    _Skill();
                    skillNum = Random.Range(0, poComboAttack.Length);
                }
            }
        }
    }
}
