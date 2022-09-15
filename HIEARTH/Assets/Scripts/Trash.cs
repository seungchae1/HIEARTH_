using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    public static bool isTouch;
    private void Start()
    {
        isTouch = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (isTouch)
        {
            this.transform.localScale = new Vector3(0f, 0f, 0f);

        }
    }

    private void OnMouseDown()
    {
        isTouch = true;
    }
}
