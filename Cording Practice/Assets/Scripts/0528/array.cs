using OpenCover.Framework.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array : MonoBehaviour
{
    class Games
    {
        public string gameName;
        public bool isPicked;

        public void Genshin()
        {
            gameName = "����";
            isPicked = false;
        }
        
        public void HonkaiStarRail()
        {
            gameName = "�ر� ��Ÿ����";
            isPicked = false;
        }

        public void BlueArchive()
        {
            gameName = "��� ��ī�̺�";
            isPicked = false;
        }

        public void LOL()
        {
            gameName = "��";
            isPicked = false;
        }
            
    }
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

        Games games = new Games();              //������ �ʿ��ؿ�

        games.Genshin();
        games.HonkaiStarRail();
        games.BlueArchive();
        games.LOL();

        string _gameName = GetComponent<Games>().gameName;
        bool _isPicked = GetComponent<Games>().isPicked;
        
        string[] poTodayGame = new string[] {"����" , "�ر� ��Ÿ����" , "��� ��ī�̺�" , "��"};
        int randomNum = Random.Range(0, 4);

        if(_gameName == poTodayGame[randomNum] && )
        {

        }
        
        
        Debug.Log("������ ������ : " + poTodayGame[randomNum]);

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
