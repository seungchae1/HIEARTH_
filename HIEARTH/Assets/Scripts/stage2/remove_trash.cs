using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class remove_trash : MonoBehaviour
{
    int cnt;
    public static bool trash;
    // Start is called before the first frame update
    void Start()
    {
        cnt = 0;
        trash = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(cnt == 34)
        {
            trash = true;
        }
    }

    private void OnMouseDown()
    {
        cnt++;
        Destroy(this.gameObject);
    }
}