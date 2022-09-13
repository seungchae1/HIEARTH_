using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    public bool istouch;
    // Start is called before the first frame update
    void Start()
    {
        istouch = false;
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Untagged")
        {
            istouch = true;

        }

    }
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.collider.tag == "Untagged")
         {
            istouch = false;
        }

    }
}
