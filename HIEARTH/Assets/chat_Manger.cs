using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class chat_Manger : MonoBehaviour
{
    private static int touchNum = 0;
    

    string[] npcChat_K =
    {
        "이방인....너어는 지나갈 수 없다 \n내가 내는 문제를 맞추도록 해!",
        "너....제법 하는 녀석이잖아?",
        "그럼 있잖아.....저기....혹시.....쓰레기 좀 주워줄래....? 헤헤\n나는...알다시피 코알라라......쓰레기 줍기에는......",
        "많이 힘들어.... 도와줄 수 있어?",
        "고마워....인간들이 버린 쓰레기 때문에 \n내 친구들이 많이 떠나가 버렸어....",
        "너는 그런 사람 아닌 것 같아 고마워",
        ""
    };

    [SerializeField] public Text npcText;

    private void Start()
    {

        npcText.text = npcChat_K[0];
        //touchNum++;
    }

    public void OnTouchedK()
    {
         
        if (touchNum == 1)
        {
            npcText.text = npcChat_K[1];
            touchNum++;
        }

        else if (touchNum == 2)
        {
            npcText.text = npcChat_K[2];
            touchNum++;
        }

        else if (touchNum == 3)
        {
            npcText.text = npcChat_K[3];
            touchNum++;
        }

        else if (touchNum == 4)
        {
            npcText.text = npcChat_K[4];
            touchNum++;
        }

        else if (touchNum == 5)
        {
            npcText.text = npcChat_K[5];
            touchNum++;
        }

        else if (touchNum == 6)
        {
            touchNum++;
        }


    }
            
    void Update()
    {

        if (npcChat_K.Length == touchNum)
        {

            npc.ischatdone = true;

        }

    }


}
