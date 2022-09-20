using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pz6 : MonoBehaviour
{
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
        if (player_p2.rock5)
        {
            img.sprite = sprite_img;
            pz1.pzNum++;
        }
    }
}
