using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toForest1 : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("stageForest1");
        player_p1.position = new Vector3(-6.0f, 0f, 0f);
    }
}
