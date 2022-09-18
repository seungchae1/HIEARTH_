using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Jump : MonoBehaviour
{
    public Transform player;
    public float jump;

    bool isjump=false;
    float thisy;
    Rigidbody2D rigid;
    Animator animator;

    void Start()
    {
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
            Debug.Log("asdfasfs");
            rigid.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
            isjump = false;
        }
        if (Touch.istouch==false)
        {
            if (player.transform.position.y >= thisy + (jump - 1.0))
                animator.SetBool("isjump", true);
        }
    }
    public void Up()
    {
        isjump = false;
    }
    public void Down()
    {
        if (Touch.istouch)
        {
            isjump = true;
        }
    }
}
