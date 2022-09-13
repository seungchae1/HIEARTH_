using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getTrash : MonoBehaviour
{
    Trash t;
    int cnt;
    bool touch;
    // Start is called before the first frame update
    void Start()
    {
        t = new Trash();
        cnt = 0;
        touch = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(t.isTouch)
        {
            if (touch)
            {
                cnt++;
                this.transform.localScale = new Vector3(0f, 0f, 0f);
            }
        }
    }
    private void OnMouseDown()
    {
        touch = true;
    }
}
