using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc2 : MonoBehaviour
{
    public GameObject npcN_;
    public GameObject npc_5 = null;

    public GameObject move;

    private void Update()
    {
        Debug.Log(chat_Manger.touchNum);
        if (npc.ischatdone == 2)
        {

            move.SetActive(true);
            npc_5.SetActive(false);
        }
        if (npc.npcNum[4] == 1)
        {
            npcN_.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "npcN")
        {
            if (npc.npcNum[4] == 0)
            {
                
                npc.ischatdone = 1;

                //camera.transform.position = new Vector3(11.0f, 0.0f, -10.0f);
                //this.transform.position = new Vector3(12.4f, -0.2f, 0.0f);

                move.SetActive(false);
                npc_5.SetActive(true);
                chat_Manger.touchNum = 1;

                npcN_.GetComponent<BoxCollider2D>().enabled = false;
            }
        }
    }
}