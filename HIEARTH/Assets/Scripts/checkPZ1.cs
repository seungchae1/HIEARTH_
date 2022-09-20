using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class checkPZ1 : MonoBehaviour
{
    public GameObject PZcheck;
    public GameObject PZchecktxt;

    // Update is called once per frame
    void Update()
    {
        if(pz1.pzNum == 8)
        {
            PZcheck.SetActive(false);
        }
            
    }



    public void PZcheckF()
    {
        
        if (pz1.pzNum != 8)
        {
            PZchecktxt.SetActive(true);
            Invoke("PZcheckFtxt", 1f);
        }
        else
        {
            SceneManager.LoadScene("stageSea1");
            //cam.transform.position = new Vector3(11.0f, 0.0f, -10.0f);
            Time.timeScale = 1f;
        }
    }

    void PZcheckFtxt()
    {

        PZchecktxt.SetActive(false);
    }
}
    