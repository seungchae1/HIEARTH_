using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toSea1 : MonoBehaviour
{
    public Object cam;
    public void SceneChange()
    {
        SceneManager.LoadScene("stageSea1");
        //cam.transform.position = new Vector3(11.0f, 0.0f, -10.0f);
    }
}

