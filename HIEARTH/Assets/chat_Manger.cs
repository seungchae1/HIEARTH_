using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class chat_Manger : MonoBehaviour
{
    public static int touchNum = 0;
    public GameObject quizK;
    public GameObject quizT;
    public GameObject quizW;

    string[] npcChat_K =
    {
        "�̹���....�ʾ�� ������ �� ���� \n���� ���� ������ ���ߵ��� ��!",
        "��....���� �ϴ� �༮���ݾ�?",
        "�׷� ���ݾ� Ȥ��....������ �� �ֿ��ٷ�....? ",
        "���� ����...�˴ٽ��� �ھ˶��......������ �ݱ⿡��......",
        "���� �����.... ������ �� ����?",
        "����....�ΰ����� ���� ������ ������ \n�� ģ������ ���� ������ ���Ⱦ�....",
        "�ʴ� �׷� ��� �ƴ� �� ���� ����",
        ""
    };

    string[] npcChat_W =
    {
        "�ΰ��̾� �ΰ�!!!",
        "�� ���� �� ��ġ���� ������?!?!\n���Ӹ� �Ⱥ���?? �� �ȳ���?",
        "�׷� ���� ���� ������ Ǯ�� ���� �� �� �ְ� ������",
        "�⺻������ ȯ�濡 ���� ������ �ִ� ����̱�\n�������� ����",
        ""
    };

    string[] npcChat_T =
    {
        "�̰��� ���� ��������? �� ������ ���� �� �� �ִٸ� �������� ����",
        "�� ��� ���ߴٴ�... �� �������� ����� �� ����",
        /*
        "�߰ſ� ����� ����� �ڵ��� ��Ŀ�� ����.... ���� ���� ��Ÿ�� �־�.\n����ü �� ���� ������ �˰�;�. �� ������ �� �ְھ�?",
        "�� ���Ŵ� ���� �ǹ���...?",
        "����! �� ���� �ٷ� ���� ��� ���̾�.",
        */
        ""
    };

    [SerializeField] public Text npcTextk;
    [SerializeField] public Text npcTextw;
    [SerializeField] public Text npcTextt;


    void Awake()
    {

        npcTextk.text = npcChat_K[0];
        touchNum = 1;

        npcTextw.text = npcChat_W[0];


        npcTextt.text = npcChat_T[0];

    }

    public void offquizK()
    {
        quizK.SetActive(false);
        touchNum++;
        Debug.Log("jk" + touchNum);
    }


        public void OnTouchedK()
    {
       // Debug.Log(touchNum);
        if (touchNum == 1)
        {
            quizK.SetActive(true);
            npcTextk.text = npcChat_K[1];
            touchNum++;
            //Debug.Log("jk" + touchNum);


        }
        if (touchNum == 2)
        {

            npcTextk.text = npcChat_K[2];
            touchNum++;
            //Debug.Log("jk" + touchNum);


        }

        else if (touchNum == 3)
        {
            Debug.Log("jas" + touchNum);
            npcTextk.text = npcChat_K[3];
            touchNum++;

        }

        else if (touchNum == 4)
        {
            npcTextk.text = npcChat_K[4];
            touchNum++;

        }

        else if (touchNum == 5)
        {
            npcTextk.text = npcChat_K[5];
            touchNum++;
            npc.istrashclear = false;
        }

        else if (touchNum == 6)
        {
            npcTextk.text = npcChat_K[6];
            touchNum++;
        }

        else if (touchNum == 7)
        {
            npcTextk.text = npcChat_K[7];
            touchNum++;
        }

        

        else if (touchNum == 9)
        {
            touchNum++;
        }

        if (npcChat_K.Length == touchNum)
        {

            npc.ischatdone = true;
            touchNum = 1;
        }

    }


    public void OnTouchedW()
    {

        if (touchNum == 1)
        {
           
            npcTextw.text = npcChat_W[1];
            touchNum++;
        }

        else if (touchNum == 2)
        {
            Debug.Log("1" + touchNum);
            npcTextw.text = npcChat_W[2];
            touchNum++;
        }

        else if (touchNum == 3)
        {
            npcTextw.text = npcChat_W[3];
            touchNum++;
        }

        else if (touchNum == 4)
        {
            npcTextw.text = npcChat_W[4];
            touchNum++;
        }
        else if (touchNum == 5)
        {
            touchNum++;
        }
        if (npcChat_W.Length == touchNum)
        {

            npc.ischatdone = true;
            touchNum = 1;
        }

    }

    public void OnTouchedT()
    {

        if (touchNum == 1)
        {

            npcTextt.text = npcChat_T[1];
            touchNum++;
        }

        else if (touchNum == 2)
        {
            touchNum++;
        }
        if (npcChat_T.Length == touchNum)
        {

            npc.ischatdone = true;
        }

    }



}
