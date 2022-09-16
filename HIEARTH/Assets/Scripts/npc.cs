using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc : MonoBehaviour
{
    //npc ����
    public static bool[] npcNum = { false, false, false, false };

    //��ȭ ������
    public static int ischatdone = 0;

    //ī�޶� ����
    public GameObject camera;

    //npc
    public GameObject npcK_;
    public GameObject npcW_;
    public GameObject npcT_;
    public GameObject npcS_;

    //��ȭâ
    public GameObject npc_1;
    public GameObject npc_2;
    public GameObject npc_3;
    public GameObject npc_4;

    //����Ű ����
    public GameObject move;



//������ ����
    public static int istrashclear = 0;

    private void Update()
    {
        if (ischatdone == 2)
        {
            move.SetActive(true);
            npc_1.SetActive(false);
            npc_2.SetActive(false);
            npc_3.SetActive(false);
            npc_4.SetActive(false);
        }

            if (istrashclear == 1)
            {

                move.SetActive(true);
                npc_1.SetActive(false);

            }

            if (istrashclear == 2)
            {
                move.SetActive(false);
                npc_1.SetActive(true);
                istrashclear = 0;

        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //�ھ˶�� ������
        if (collision.transform.tag == "npcK")
        {
            if (npcNum[0] == false)
            {
                npcNum[0] = true;
                ischatdone = 1;

                //camera.transform.position = new Vector3(11.0f, 0.0f, -10.0f);
                //this.transform.position = new Vector3(12.4f, -0.2f, 0.0f);

                move.SetActive(false);
                npc_1.SetActive(true);
                chat_Manger.touchNum = 1;

                npcK_.GetComponent<BoxCollider2D>().enabled = false;
            }
        }

        //������ ������
        if (collision.transform.tag == "npcW")
        {
            if (npcNum[1] == false)
            {
                npcNum[1] = true;
                ischatdone = 1;

                //camera.transform.position = new Vector3(11.0f, 0.0f, -10.0f);
                //this.transform.position = new Vector3(12.4f, -0.2f, 0.0f);

                move.SetActive(false);
                npc_2.SetActive(true);
                chat_Manger.touchNum = 1;

                npcW_.GetComponent<BoxCollider2D>().enabled = false;
            }
        }

        if (collision.transform.tag == "npcT")
        {
            if (npcNum[2] == false)
            {
                npcNum[2] = true;
                ischatdone = 1;

                //camera.transform.position = new Vector3(11.0f, 0.0f, -10.0f);
                //this.transform.position = new Vector3(12.4f, -0.2f, 0.0f);

                move.SetActive(false);
                npc_3.SetActive(true);
                chat_Manger.touchNum = 1;

                npcT_.GetComponent<BoxCollider2D>().enabled = false;
            }
        }

        if (collision.transform.tag == "npcS")
        {
            if (npcNum[3] == false)
            {
                npcNum[3] = true;
                ischatdone = 1;

                //camera.transform.position = new Vector3(11.0f, 0.0f, -10.0f);
                //this.transform.position = new Vector3(12.4f, -0.2f, 0.0f);

                move.SetActive(false);
                npc_4.SetActive(true);
                chat_Manger.touchNum = 1;

                npcS_.GetComponent<BoxCollider2D>().enabled = false;
            }
        }

    }

}
