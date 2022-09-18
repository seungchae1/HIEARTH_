using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveShip : MonoBehaviour
{
    bool start;
    public GameObject smoke;
    // Start is called before the first frame update 20.5ø°º≠ ∏ÿ√ﬂ±‚
    void Start()
    {
        start = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (start)
        {
            if (ClickRope.Rope)
            {
                if (!(playerMove.left && playerMove.right))
                {
                    GameObject.Find("player").transform.position += Vector3.right * 1.0f * Time.deltaTime;
                    this.transform.position += Vector3.right * 1.0f * Time.deltaTime;
                    smoke.SetActive(true);
                }
                else this.transform.position += Vector3.right * 1.0f * Time.deltaTime;
            }
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Player")
        {
            start = true;
        }
        else if(col.collider.tag == "Untagged")
        {
            start = false;
        }

    }
}
