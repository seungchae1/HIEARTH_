using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Jump : MonoBehaviour
{
    Touch t;

    public Transform player;
    public float jump;
    bool isjump=false;
    float thisy;
    Rigidbody2D rigid;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        t = GameObject.Find("player").GetComponent<Touch>();
        rigid = player.GetComponent<Rigidbody2D>();
        animator = player.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("isjump", false);
        thisy = player.position.y;
        if (isjump)
        {
            rigid.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
            if (player.transform.position.y >= thisy)
            {
                isjump = false;
            }
        }
        if (t.istouch==false)
        {
            animator.SetBool("isjump", true);
        }
    }
    public void Up()
    {
        isjump = false;
    }
    public void Down()
    {
        if (t.istouch)
        {
            isjump = true;
        }
    }
}
