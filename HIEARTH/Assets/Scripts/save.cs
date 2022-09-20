using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class save : MonoBehaviour
{
    public GameObject save1;
    public GameObject save2;
    public GameObject save3;
    public GameObject save4;
    public GameObject save5;

    public static bool reset = false;

    int loc =0;

    /*
    private void Update()
    {
        Debug.Log("ghgh" + reset);
        if(reset)
        {
            save1.GetComponent<BoxCollider2D>().enabled = true;
            save2.GetComponent<BoxCollider2D>().enabled = true;
            save3.GetComponent<BoxCollider2D>().enabled = true;
            save4.GetComponent<BoxCollider2D>().enabled = true;
            save5.GetComponent<BoxCollider2D>().enabled = true;

            reset = false;
        }
    }
    */

    //GameObject Player;

    private void Awake()
    {
        //Player = GameObject.Find("player");
       // PlayerPrefs.DeleteAll();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //save
        if (collision.transform.tag == "Respawn")
        {
            Debug.Log("000000000");
            Save2.isstg2 = false;
            saveloc();
            
        }

        //save
        if (collision.transform.tag == "save")
        {
            

            loc = 1;
            PlayerPrefs.SetInt("saveloc", loc);
            save1.GetComponent<BoxCollider2D>().enabled = false;
            Debug.Log("11");

            PlayerPrefs.SetInt("savenpc", npc.npcNum[0]);
            PlayerPrefs.SetInt("savenpc1", npc.npcNum[1]);
            PlayerPrefs.SetInt("savenpc2", npc.npcNum[2]);
            PlayerPrefs.SetInt("savenpc3", npc.npcNum[3]);



        }

        //save
        if (collision.transform.tag == "save2")
        { 
            loc = 2;
            PlayerPrefs.SetInt("saveloc", loc);
            save2.GetComponent<BoxCollider2D>().enabled = false;
            Debug.Log("22");

            PlayerPrefs.SetInt("savenpc", npc.npcNum[0]);
            PlayerPrefs.SetInt("savenpc1", npc.npcNum[1]);
            PlayerPrefs.SetInt("savenpc2", npc.npcNum[2]);
            PlayerPrefs.SetInt("savenpc3", npc.npcNum[3]);
        }

        //save
        if (collision.transform.tag == "save3")
        {
            loc = 3;
            PlayerPrefs.SetInt("saveloc", loc);
            save3.GetComponent<BoxCollider2D>().enabled = false;
            Debug.Log("33");

            PlayerPrefs.SetInt("savenpc", npc.npcNum[0]);
            PlayerPrefs.SetInt("savenpc1", npc.npcNum[1]);
            PlayerPrefs.SetInt("savenpc2", npc.npcNum[2]);
            PlayerPrefs.SetInt("savenpc3", npc.npcNum[3]);
        }

        //save
        if (collision.transform.tag == "save4")
        {
            loc = 4;
            PlayerPrefs.SetInt("saveloc", loc);
            save4.GetComponent<BoxCollider2D>().enabled = false;
            Debug.Log("44");

            PlayerPrefs.SetInt("savenpc", npc.npcNum[0]);
            PlayerPrefs.SetInt("savenpc1", npc.npcNum[1]);
            PlayerPrefs.SetInt("savenpc2", npc.npcNum[2]);
            PlayerPrefs.SetInt("savenpc3", npc.npcNum[3]);
        }

        //save
        if (collision.transform.tag == "save5")
        {
            loc = 5;
            PlayerPrefs.SetInt("saveloc", loc);
            save5.GetComponent<BoxCollider2D>().enabled = false;
            Debug.Log("55");

            PlayerPrefs.SetInt("savenpc", npc.npcNum[0]);
            PlayerPrefs.SetInt("savenpc1", npc.npcNum[1]);
            PlayerPrefs.SetInt("savenpc2", npc.npcNum[2]);
            PlayerPrefs.SetInt("savenpc3", npc.npcNum[3]);
        }
    }

        void saveloc()
        {
        Debug.Log("popo");

        loc = PlayerPrefs.GetInt("saveloc");
        npc.npcNum[0] = PlayerPrefs.GetInt("savenpc");
        npc.npcNum[1] = PlayerPrefs.GetInt("savenpc1");
        npc.npcNum[2] = PlayerPrefs.GetInt("savenpc2");
        npc.npcNum[3] = PlayerPrefs.GetInt("savenpc3");

        if (loc == 1)
        {
            Debug.Log("asdfasdf" + loc);
            this.transform.position = new Vector3(24.6f, 0.4f, 0.0f);
        }
                

            if (loc == 2)
            this.transform.position = new Vector3(60.0f, 0.1f, 0.0f);

            if (loc == 3)
        {
            this.transform.position = new Vector3(41.8f, 2.0f, 0.0f);
            SceneManager.LoadScene("stageForest2");
            
        }


        if (loc == 4)
        {
            this.transform.position = new Vector3(74.1f, -1.6f, 0.0f);
            SceneManager.LoadScene("stageForest2");
        }
        if (loc == 5)
        {
            this.transform.position = new Vector3(6.6f, 0.0f, 90.0f);
            SceneManager.LoadScene("stageForest3");
            
        }

        }
    }

    

   

