using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class remove_trash : MonoBehaviour
{
    public static int cnt=0;
    public static bool trash;
    // Start is called before the first frame update
    void Start()
    {
        trash = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnMouseDown()
    {
        cnt++;
        Destroy(this.gameObject);
    }
}