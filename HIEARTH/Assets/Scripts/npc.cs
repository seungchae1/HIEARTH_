using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc : MonoBehaviour {

    public static int[] npcNum = { 0, 0, 0, 0 };
    public static bool ischatdone = true;

    //npc
    public GameObject npcK_;
    public GameObject npcW_;
    public GameObject npcT_;
    public GameObject npcS_;


    //대화창
    public GameObject npc_1;
    public GameObject npc_2;
    public GameObject npc_3;
    public GameObject npc_4;

    //방향키 끄기
    public GameObject move;
    private void Update()
    {
        if (ischatdone == true)
        {

            npc_1.SetActive(false);
            move.SetActive(true);


        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (collision.transform.tag == "npcK")
        {
            ischatdone = false;


            //일단 npc대화 진행했나 안했나 확인
            if (npcNum[0] == 0)
            {
                npc_1.SetActive(true);
                npcK_.GetComponent<BoxCollider2D>().enabled = false; //앞으로 갈수 있게 컴포넌트 비활성화
                move.SetActive(false);
                npcNum[0] = 1;
                

                


            }

            
                
        }

        

        if (collision.transform.tag == "npcW")
        {
            //Debug.Log("npc");

            //일단 npc대화 진행했나 안했나 확인
            if (npcNum[1] == 0)
            {
                npc_2.SetActive(true);

                if (Input.GetTouch(0).phase == TouchPhase.Ended)
                {

                }

                npcW_.GetComponent<BoxCollider2D>().enabled = false; //앞으로 갈수 있게 컴포넌트 비활성화
                npcNum[1] = 1;
            }

        }

        if (collision.transform.tag == "npcT")
        {
            //Debug.Log("npc");

            //일단 npc대화 진행했나 안했나 확인
            if (npcNum[2] == 0)
            {
                npc_3.SetActive(true);

                if (Input.GetTouch(0).phase == TouchPhase.Ended)
                {

                }

                npcT_.GetComponent<BoxCollider2D>().enabled = false; //앞으로 갈수 있게 컴포넌트 비활성화
                npcNum[2] = 1;
            }

        }

        if (collision.transform.tag == "npcS")
        {
            //Debug.Log("npc");

            //일단 npc대화 진행했나 안했나 확인
            if (npcNum[3] == 0)
            {
                npc_4.SetActive(true);

                if (Input.GetTouch(0).phase == TouchPhase.Ended)
                {

                }

                npcS_.GetComponent<BoxCollider2D>().enabled = false; //앞으로 갈수 있게 컴포넌트 비활성화
                npcNum[3] = 1;
            }

        }
    }
}
