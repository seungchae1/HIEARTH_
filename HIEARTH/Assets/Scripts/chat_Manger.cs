using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class chat_Manger : MonoBehaviour
{
    public static int touchNum = 0;

    [SerializeField] public Text npcTextk;
    [SerializeField] public Text npcTextw;
    [SerializeField] public Text npcTextt;
    [SerializeField] public Text npcTexts;
    
    public GameObject quizK;
    public GameObject quizT;
    public GameObject quizW;
    public GameObject quizS;

    public GameObject chatT;

    //length 7
    string[] npcChat_K =
    {
        "�̹���....�ʾ�� ������ �� ���� \n���� ���� ������ ���ߵ��� ��!",
        "��....���� �ϴ� �༮���ݾ�?",
        "�׷� ���ݾ� Ȥ��....������ �� �ֿ��ٷ�....? ",
        "���� ����...�˴ٽ��� �ھ˶��......������ �ݱ⿡��......",
        "���� �����.... ������ �� ����?",
        "����....�ΰ����� ���� ������ ������ \n�� ģ������ ���� ������ ���Ⱦ�....",
        "�ʴ� �׷� ��� �ƴ� �� ���� ����"
    };

    //length 4
    string[] npcChat_W =
        {
            "�ΰ��̾� �ΰ�!!!",
            "�� ���� �� ��ġ���� ������?!?!\n���Ӹ� �Ⱥ���?? �� �ȳ���?",
            "�׷� ���� ���� ������ Ǯ�� ���� �� �� �ְ� ������",
            "�⺻������ ȯ�濡 ���� ������ �ִ� ����̱�\n�������� ����"
        };

    //legnth 5
    string[] npcChat_T =
    {
        "�̰��� ���� ��������? �� ������ ���� �� �� �ִٸ� �������� ����",
        "�� ��� ���ߴٴ�... �� �������� ����� �� ����",
        "�߰ſ� ����� ����� �ڵ��� ��Ŀ�� ����.... ���� ���� ��Ÿ�� �־�.\n����ü �� ���� ������ �˰�;�. �� ������ �� �ְھ�?",
        "�� ���Ŵ� ���� �ǹ���...?",
        "����! �� ���� �ٷ� ���� ��� ���̾�.",
    };

    string[] npcChat_S =
    {
        "�ƿ�-!! �� ��! �� ��! ���İ�!! �� �� Ÿ�����ž�?",
        "�̰� ȭ���� ����...? �� ���� �� ������? ���� ������ ��!",
        "����!! ���� �� �Ͼ��ٰ�!"
    };

    void Start()
    {
        npcTextk.text = npcChat_K[0];
        npcTextw.text = npcChat_W[0];
        npcTextt.text = npcChat_T[0];
        //npcTexts.text = npcChat_S[0];
       // Debug.Log("asdf"+npcChat_S[0]);
    }
    private void Update()
    {
        Debug.Log(touchNum);
        //Debug.Log(npcChat_S[0]);
    }

    public void offquizK()
    {
        quizK.SetActive(false);
    }

    public void offquizW()
    {
        quizW.SetActive(false);
    }

    public void offquizT()
    {
        quizT.SetActive(false);
    }

    public void offquizS()
    {
        quizS.SetActive(false);
    }

    public void chatT1()
    {
        
        npcTextt.text = npcChat_T[3];
            touchNum++;
        chatT.SetActive(false);

    }

    public void chatT2()
    {
       
        npcTextt.text = npcChat_T[4];
            touchNum++;
        chatT.SetActive(false);

    }

    public void OnTouchedK()
    {
        if (touchNum == 1)
        {
            quizK.SetActive(true);
            npcTextk.text = npcChat_K[1];
            touchNum++;//2
        }
        else if (touchNum == 2)
        {
            npcTextk.text = npcChat_K[2];
            touchNum++;//3
        }
        else if (touchNum == 3)
        {
            npcTextk.text = npcChat_K[3];
            touchNum++;//4
        }
        else if (touchNum == 4)
        {
            npcTextk.text = npcChat_K[4];
            touchNum++;
        }
        else if (touchNum == 5)
        {

            npcTextk.text = npcChat_K[5];
            npc.istrashclear = 1;
            touchNum++;
        }
        else if (touchNum == 6)
        {
            npcTextk.text = npcChat_K[6];
            touchNum++;
        }
        else if (touchNum == 7)
        {
            npc.ischatdone = 2;
           
        }
     
    }

    public void OnTouchedW()
    {
        if (touchNum == 1)
        {
            
            npcTextw.text = npcChat_W[1];
            touchNum++;//2
        }
        else if (touchNum == 2)
        {
            
            npcTextw.text = npcChat_W[2];
            touchNum++;//3
        }
        else if (touchNum == 3)
        {
            quizW.SetActive(true);
            npcTextw.text = npcChat_W[3];
            touchNum++;//4
        }
       
        else if (touchNum == 4)
        {
            npc.ischatdone = 2;

        }

    }

    public void OnTouchedT()
    {
        if (touchNum == 1)
        {
            quizT.SetActive(true);
            npcTextt.text = npcChat_T[1];
            touchNum++;//2
        }
        else if (touchNum == 2)
        {
            npcTextt.text = npcChat_T[2];
            touchNum++;//3
        }
        else if (touchNum == 3)
        {
            chatT.SetActive(true);
        }
 
        else if (touchNum == 4)
        {
            npc.ischatdone = 2;

        }
        

    }

    public void OnTouchedS()
    {
        Debug.Log("asdf");
        if (touchNum == 1)
        {
            
            npcTexts.text = npcChat_S[1];
            touchNum++;//2
        }
        else if (touchNum == 2)
        {
            quizS.SetActive(true);
            npcTexts.text = npcChat_S[2];
            touchNum++;//3
        }

        else if (touchNum == 3)
        {
            npc.ischatdone = 2;

        }


    }

   
}



