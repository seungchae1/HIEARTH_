using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toForest2 : MonoBehaviour
{
    public float point;
    void Update()
    {
        if(this.transform.position.x >= point)
        {
            SceneManager.LoadScene("stageForest2");
        }
    }
}
