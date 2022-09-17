using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removeFruit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y <= 0)
            GetComponent<BoxCollider2D>().enabled = true;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(this.gameObject);
    }
}
