using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElseExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int POHeight = 161;
        int DragonChanHeight = 175;

        if(POHeight > DragonChanHeight)
        {
            Debug.Log("�̰� ���� �ȵ�!");
        }
        else if(POHeight == 180)
        {
            Debug.Log("�̰� �� ���� �ȵ�");
        }
        else
        {
            Debug.Log("�̰� ����");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
