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
            Debug.Log("이건 말도 안돼!");
        }
        else if(POHeight == 180)
        {
            Debug.Log("이건 더 말이 안돼");
        }
        else
        {
            Debug.Log("이게 맞지");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
