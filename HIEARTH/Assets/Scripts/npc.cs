using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc : MonoBehaviour
{

    public static int[] npcNum = { 0, 0, 0, 0 };
    public static bool ischatdone = true;
    public static bool istrashclear = true;

    public GameObject camera;



    //npc
    public GameObject npcK_;
    public GameObject npcW_;
    public GameObject npcT_;


    //��ȭâ
    public GameObject npc_1;
    public GameObject npc_2;
    public GameObject npc_3;

    //����Ű ����
    public GameObject move;
    private void Update()
    {
        Debug.Log(camera.transform.position);
        Debug.Log("pl"+this.transform.position);
        if (ischatdone == true)
        {

            npc_1.SetActive(false);
            npc_2.SetActive(false);
            npc_3.SetActive(false);
            Debug.Log("pl");
            move.SetActive(true);


        }

        if(istrashclear== false)
        {
            npc_1.SetActive(false);

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.transform.tag == "npcK")
        {
            ischatdone = false;


            //�ϴ� npc��ȭ �����߳� ���߳� Ȯ��
            if (npcNum[0] == 0)
            {
                
                camera.transform.position = new Vector3(11.0f, 0.0f, -10.0f);
                this.transform.position = new Vector3(12.4f, -0.2f, 0.0f);
                npc_1.SetActive(true);
                move.SetActive(false);

                npcK_.GetComponent<BoxCollider2D>().enabled = false; //������ ���� �ְ� ������Ʈ ��Ȱ��ȭ

                npcNum[0] = 1;
            }
        }

        if (collision.transform.tag == "npcW")
        {
            ischatdone = false;


            //�ϴ� npc��ȭ �����߳� ���߳� Ȯ��
            if (npcNum[1] == 0)
            {
                npc_2.SetActive(true);
                npcW_.GetComponent<BoxCollider2D>().enabled = false; //������ ���� �ְ� ������Ʈ ��Ȱ��ȭ
                move.SetActive(false);
                npcNum[1] = 1;
            }
        }

        if (collision.transform.tag == "npcT")
        {
            ischatdone = false;


            //�ϴ� npc��ȭ �����߳� ���߳� Ȯ��
            if (npcNum[2] == 0)
            {
                npc_3.SetActive(true);
                npcT_.GetComponent<BoxCollider2D>().enabled = false; //������ ���� �ְ� ������Ʈ ��Ȱ��ȭ
                move.SetActive(false);
                npcNum[2] = 1;
            }
        }
    }
}
