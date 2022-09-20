using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Save2 : MonoBehaviour
{
    public GameObject save1;
    public GameObject save22;
    public GameObject save3;
    public GameObject save4;
    public GameObject save5;

    public static bool reset2 = false;

    int loc = 0;
    public static bool isstg2 = false;

    //GameObject Player;

    /*
    private void Update()
    {
        if (reset2)
        {
            save1.GetComponent<BoxCollider2D>().enabled = true;
            save22.GetComponent<BoxCollider2D>().enabled = true;
            save3.GetComponent<BoxCollider2D>().enabled = true;
            save4.GetComponent<BoxCollider2D>().enabled = true;
            save5.GetComponent<BoxCollider2D>().enabled = true;

            reset2 = false;
        }
    }
    */


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
            isstg2 = true;
            saveloc2();
        }

        //save
        if (collision.transform.tag == "save")
        {
            loc = 1;
            PlayerPrefs.SetInt("saveloc2", loc);
            save1.GetComponent<BoxCollider2D>().enabled = false;

        }

        //save
        if (collision.transform.tag == "save2")
        {
            loc = 2;
            PlayerPrefs.SetInt("saveloc2", loc);
            save22.GetComponent<BoxCollider2D>().enabled = false;
            Debug.Log("22");
        }

        //save
        if (collision.transform.tag == "save3")
        {
            Debug.Log("asfdsdafasfsadadfafsdasdfasfd");
            loc = 3;
            PlayerPrefs.SetInt("saveloc2", loc);
            save3.GetComponent<BoxCollider2D>().enabled = false;
            Debug.Log("33");
        }

        //save
        if (collision.transform.tag == "save4")
        {
            loc = 4;
            PlayerPrefs.SetInt("saveloc2", loc);
            save4.GetComponent<BoxCollider2D>().enabled = false;
            Debug.Log("44");
        }
    }

    void saveloc2()
    {

        loc = PlayerPrefs.GetInt("saveloc2");


        if (loc == 1)
        {
            this.transform.position = new Vector3(25.4f, -2.0f, 0.0f);
        }


        if (loc == 2)
            {
                SceneManager.LoadScene("stageSea2");
                this.transform.position = new Vector3(27.9f, 1.0f, 0.0f);
            }

        if (loc == 3)
        {
            SceneManager.LoadScene("stageSea3");
            this.transform.position = new Vector3(2.7f, 0.2f, 0.0f);
        }


        if (loc == 4)
        {
            SceneManager.LoadScene("stageSea3");
            this.transform.position = new Vector3(39.6f, 0.8f, 0.0f);
        }

    }
}





