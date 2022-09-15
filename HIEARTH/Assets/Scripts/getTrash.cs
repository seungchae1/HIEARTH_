using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getTrash : MonoBehaviour
{
    public static int get;
    bool touch;

    // Start is called before the first frame update
    void Start()
    {
        get = 0;
        touch = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Trash.isTouch)
        { 
            if (touch)
            {
                this.transform.localScale = new Vector3(0f, 0f, 0f);
            }
        }
    }
    private void OnMouseDown()
    {
        touch = true;
        if(Trash.isTouch) get++;
    }
}
