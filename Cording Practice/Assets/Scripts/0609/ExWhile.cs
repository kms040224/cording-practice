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
        Debug.Log("김평오는 독에 걸려있다");
        poisonDmg = 40;
        while (hp == 0)
        {
            hp = hp - poisonDmg;
            Debug.Log(hp);
            Debug.Log("독으로 인해 김평오의 체력이 감소했다");
            
        }
        Debug.Log("김평오는 결국 쓰러졌다");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
