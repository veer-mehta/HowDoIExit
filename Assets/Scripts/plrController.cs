using System.Collections;
using System.Collections.Generic;
using String = System.String;
using Math = System.Math;
using UnityEngine;
using TMPro;


public class plrController : MonoBehaviour
{
    public TMP_InputField editor;
    Rigidbody2D plr;
    Vector3 mv;
    string s_txt;
    string[] a_txt;
    int pcp, chr;                    //Previous Caret Position

    float dt; //deltatime
    int[] moveState = {0, 0}; //movement state: 0(no input),1(moving),2(input but no moving)
    const double MTG = .2f; //movement time gap

    void Start()
    {
        //rb2d = GetComponent<Rigidbody2D>();
        dt = Time.realtimeSinceStartup;
        plr = GetComponent<Rigidbody2D>();
        pcp = editor.caretPosition;
        chr = 0;
    }


    private void Move()
    {
        if (pcp != editor.caretPosition)
        {
            //chr = editor.text[editor.caretPosition-1];

            s_txt = editor.text.Substring(0, editor.caretPosition).Replace((char)11, '\n');
            a_txt = s_txt.Split('\n');
            mv = new Vector3((a_txt[a_txt.Length - 1].Length)*.2f - 7.99f, -(s_txt.Length - s_txt.Replace("\n", "").Length)*.42f + 4.29f, -1);
            plr.transform.position = mv;
            pcp = editor.caretPosition;
        }
        Debug.Log(chr);
    }


    void Update()
    {

        Move();
        
    }


        /*
    private void Move()
    {
        mv = new Vector2(
            (moveState[0]%2 == 1 ? Input.GetAxisRaw("Horizontal")*.2f : 0),
            (moveState[1]%2 == 1 ? Input.GetAxisRaw("Vertical")*.42f : 0)
        );
        //Both pressed
        if (Input.GetAxisRaw("Horizontal") != 0 && Input.GetAxisRaw("Vertical") != 0 && (moveState[0] == 0 || (moveState[0] == 2 && Time.realtimeSinceStartup - dt >= MTG)) && (moveState[1] == 0 || (moveState[1] == 2 && Time.realtimeSinceStartup - dt >= MTG)))
        {
            moveState[0] = 1;
            moveState[1] = 1;
            dt = Time.realtimeSinceStartup;
        }
        else
        {
            //Hz pressed
            if (Input.GetAxisRaw("Horizontal") != 0 && (moveState[0] == 0 || (moveState[0] == 2 && Time.realtimeSinceStartup - dt >= MTG)))
            {
                moveState[0] = 1;
                dt = Time.realtimeSinceStartup;
            }
            else if (Input.GetAxisRaw("Horizontal") != 0)
            {
                moveState[0] = 2;
            }
            else
            {
                moveState[0] = 0;
            }
            //Vt pressed
            if (Input.GetAxisRaw("Vertical") != 0 && (moveState[1] == 0 || (moveState[1] == 2 && Time.realtimeSinceStartup - dt >= MTG)))
            {
                moveState[1] = 1;
                dt = Time.realtimeSinceStartup;
            }
            else if (Input.GetAxisRaw("Vertical") != 0)
            {
                moveState[1] = 2;
            }
            else
            {
                moveState[1] = 0;
            }
        }
        rb2d.position += mv;
    }
        */
}
