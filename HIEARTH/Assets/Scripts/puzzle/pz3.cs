using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pz3 : MonoBehaviour
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
        if (Click_rock.rock3)
        {
            img.sprite = sprite_img;
            pz1.pzNum++;
        }
    }
}
