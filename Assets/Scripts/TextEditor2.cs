using System.Collections;
using System.Collections.Generic;
using String = System.String;
using Math = System.Math;
using UnityEngine;
using TMPro;

public class TextEditor2 : MonoBehaviour
{
    public GameObject plr;
    TMP_Text txt;
    Rigidbody2D rb2d;
    Vector2 mv;
    string s, sipt;
    char k_BS, k_EN;
    string[] l;
    int slen;

    void Start()
    {
        k_BS = '\b';
        //k_EN = '\n';
        txt = GetComponent<TMP_Text>();
        rb2d = plr.GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        sipt += Input.inputString;
        slen = sipt.Length;
    }

    void FixedUpdate()
    {
        if (sipt != "")
        {
            s = txt.text;
            int posx = (int)(Math.Round((plr.transform.position.x/.2) + 40));
            int posy = -(int)(Math.Round((plr.transform.position.y/.42) - 10.23));

            //l[posy].Replace(k_EN, );


            //for (int i = 0; i < s.Split('\n').Length; i=s.IndexOf('\n', ))
            {

            
}

            l = s.Split("\n");

            if (l.Length <= posy)
            {
                s += (new string('\n', posy+1 - l.Length));
            }
            l = s.Split("\n");
            if (l[posy].Length < posx)
            {
                l[posy] += (new string(' ', posx - l[posy].Length));
            }

            l[posy] = l[posy].Substring(0, posx) + sipt + l[posy].Substring(posx, l[posy].Length - posx);   //NORMAL


            while (l[posy].IndexOf(k_BS) != -1)                     //BACKSPACE
            {
                if (l[posy][0] == k_BS)
                {
                    if (l[posy].Length == 1)
                    {
                        l[posy] = "";
                    }
                    else
                    {
                        Debug.Log(l[posy].Length);
                        l[posy] = l[posy].Substring(1, l[posy].Length);
                    }
                    slen-=1;
                }
                else
                {
                    l[posy] = l[posy].Substring(0, l[posy].IndexOf(k_BS)-1) + l[posy].Substring(l[posy].IndexOf(k_BS)+1, l[posy].Length - l[posy].IndexOf(k_BS)-1);
                    slen-=2;
                }
            }



            //while (l[posy].IndexOf(k_EN) != -1)
            {

            }
            

            mv[0] = 0.2f*(slen);
            rb2d.position += mv;
            txt.SetText(string.Join("\n", l));

            sipt = "";
        }
    }

}
