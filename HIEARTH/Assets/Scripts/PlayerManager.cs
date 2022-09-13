using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
    

    //public static bool[] ncpTF = { false };
    //public GameObject npcK;

    // Start is called before the first frame update
    void Awake()
    {
        isGameOver = false;

    }


   
  
   
    /*public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }*/
}
