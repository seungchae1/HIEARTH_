using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc3 : MonoBehaviour
{

    //대화 끝여부
    public static int ischatdone = 0;

    //카메라 고정
    public GameObject camera;

    //npc

    public GameObject npcS_;

    //대화창

    public GameObject npc_4;

    //방향키 끄기
    public GameObject move;

    private void Update()
    {
        if (ischatdone == 2)
        {
            move.SetActive(true);
            npc_4.SetActive(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "npcS")
        {
            if (npc.npcNum[3] == false)
            {
                npc.npcNum[3] = true;
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
