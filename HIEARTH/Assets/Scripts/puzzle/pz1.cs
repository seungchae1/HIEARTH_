using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pz1 : MonoBehaviour
{
    public static int pzNum = 0;
    Image img;
    public Sprite sprite_img;
    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player_p1.rock1)
        {
            img.sprite = sprite_img;
            pzNum++;
        }
    }
}
