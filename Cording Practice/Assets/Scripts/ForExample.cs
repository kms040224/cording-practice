using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int SheepNum = 0;
        for(int i = 0; i < 100; i++)
        {
            if(i > 0)
            {
                SheepNum++;

                Debug.Log("양이" + SheepNum + "마리...");
            }
        }    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
