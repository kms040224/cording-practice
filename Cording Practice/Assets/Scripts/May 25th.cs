using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class May25th : MonoBehaviour
{
    public void GenerateCharacter(string name, int level)
    {
        Debug.LogFormat("Character: {0} - Level: {1}",name,level);  //���ο� �Ű������� ����ϵ��� Debug.LogFormat�� ����� ������Ʈ
        //����� �Ű����� ����
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
