using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExWhile : MonoBehaviour
{

    public int turn = 0;
    public int hp = 320;
    public int poisonDmg = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        Poison();
    }

    public void Poison()
    {
        Debug.Log("������� ���� �ɷ��ִ�");
        poisonDmg = 40;
        while (hp == 0)
        {
            hp = hp - poisonDmg;
            Debug.Log(hp);
            Debug.Log("������ ���� ������� ü���� �����ߴ�");
            
        }
        Debug.Log("������� �ᱹ ��������");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
