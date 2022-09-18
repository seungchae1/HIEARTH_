using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Jump : MonoBehaviour
{
    public Transform player;
    public float jump;
    bool isjump=false;
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
        if (isjump)
        {
            rigid.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
            isjump = false;
        }
        if (Touch.istouch==false)
        {
            if (player.transform.position.y >= 0.5f)
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
