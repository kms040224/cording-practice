using System.Collections.Generic;
using UnityEngine;
public class Array : MonoBehaviour
{
    public List<string> gameNames = new List<string>();
    void Start()
    {
        DataReset();
    }
    public void DataReset()                                 //gameNames �ȿ� .Add�� ����Ͽ� ���� �־���
    {
        Debug.Log("Reset!");
        gameNames.Clear();
        gameNames.Add("����");
        gameNames.Add("�ر� ��Ÿ����");
        gameNames.Add("��� ��ī�̺�");
        gameNames.Add("��");
    }
    public string poTodaysGame()
    {
        if (gameNames.Count <= 0)                           //����Ʈ �ȿ� ������ ���� �־���
            DataReset();

        var random = Random.Range(0, gameNames.Count);      //var ���������� �������� ����
        var name = gameNames[random];                       //Random.range�� ����Ͽ� ���� �������� �ش��ϴ� ���� �̸��� name ������ ����
        gameNames.Remove(gameNames[random]);                //�ش��ϴ� ���� ��µɶ� Remove�� ����Ͽ� ����Ʈ ���� ���� ����

        return name;                                        //name ���� ���
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))                 //�����̽��ٸ� ������
        {
            Debug.Log(poTodaysGame());                       //�ܼ�â�� ������ ����� �� ������ ���
        }
    }
}