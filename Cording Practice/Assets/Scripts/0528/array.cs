using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array : MonoBehaviour
{

    //�迭�� ��� Ÿ���� ���� ���� ����(�̶� ��� ��Ҵ� ������ Ÿ��)
    //�迭�� ���� �� ���̳� ����� ������ ���� ���� (���Ŀ� ������ �Ұ����ϴ�(?))
    //�迭�� ������ �� �ʱⰪ�� �������� ������ �⺻���� �����ȴ�. integer�� ���� ���� �������� ��쿡�� 0���� �ڵ� �����ǰ� �ٸ� Ÿ���� null���̳� �̼��� ���°� �ȴ�.

    void Start()
    {
        // *�迭 ������ �ʿ��Ѱ� -> ����� Ÿ��(������ ��) �� ���ȣ ��,������ �̸��� �ʿ��ϴ�.
        //new Ű������ ��� �޸𸮿� �迭�� �����ϴ� �� ���Ǹ� �� Ÿ�԰� ���ȣ ���� �ڿ� ����´�.�迭�� ������ ����� ������ �ι�° ���ȣ �� �ȿ� ����.

        //�Ϲ� �ʱ�ȭ
        //string[] poFavoriteGame = new string[] { "����", "�ر� ��Ÿ����", "��� ��ī�̺�","��" };

        //���� �ʱ�ȭ
        //string[] poFavoriteGame = { "����", "�ر� ��Ÿ����", "��� ��ī�̺�","��" };

       
    }

    public void poTodaysGame()
    {
        string[] poFavoriteGame = new string[] { "����", "�ر� ��Ÿ����", "��� ��ī�̺�", "��" };
        int randomNum = Random.Range(0, 4);

        Debug.Log("������ ������ : " + poFavoriteGame[randomNum]);

        //���� ���Դ��� �ȳ����� �ٲ㺼 ��

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            poTodaysGame();
        }
        
        
    }
}
