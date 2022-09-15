using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getTrash : MonoBehaviour
{
    Trash t;
    bool get;
    bool touch;
    int trashGet;

    // Start is called before the first frame update
    void Start()
    {
        t = GameObject.Find("trash_bag").GetComponent<Trash>();
        get = false;
        touch = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(t.isTouch)
        { 
            if (touch)
            {
                this.transform.localScale = new Vector3(0f, 0f, 0f);
                trashGet++;
            }
        }

        if (trashGet == 4)
        {
           //npc_1.SetActive(false);
        }
    }
    private void OnMouseDown()
    {
        touch = true;
        if(t.isTouch) get=true;
    }
}
