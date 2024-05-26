using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class May25th : MonoBehaviour
{
    public void GenerateCharacter(string name, int level)
    {
        Debug.LogFormat("Character: {0} - Level: {1}",name,level);  //새로운 매개변수를 사용하도록 Debug.LogFormat을 사용해 업데이트
        //사용한 매개변수 지정
    }
    // Start is called before the first frame update
    void Start()
    {
        int CharacterLevel = 32;
        GenerateCharacter("Spike",CharacterLevel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
