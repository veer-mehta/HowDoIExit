using System.Collections;
using System.Collections.Generic;
using String = System.String;
using Math = System.Math;
using UnityEngine;
using TMPro;


public class TextEditor : MonoBehaviour
{
    public GameObject plr;
    TMP_InputField editor;
    Rigidbody2D rb2d;
    Vector3 mv;
    string s_txt;
    string[] a_txt;
    int pcp, chr;                    //Previous Caret Position
    /*string s, sipt;
    char k_BS, k_EN;
    string[] l;
    int slen;*/

    void Start()
    {
        editor = GetComponent<TMP_InputField>();
        editor.caretWidth = 0;
        editor.ActivateInputField();
    }

    void FixedUpdate()
    {
        editor.text = editor.text.Replace((char)11, '\n');
        /*
        if (pcp != editor.caretPosition)
        {
            //chr = editor.text[editor.caretPosition-1];

            s_txt = editor.text.Substring(0, editor.caretPosition).Replace((char)11, '\n');
            a_txt = s_txt.Split('\n');
            //mv = 
            plr.transform.position = new Vector3((a_txt[a_txt.Length - 1].Length)*.2f - 7.99f, -(s_txt.Length - s_txt.Replace("\n", "").Length)*.42f + 4.29f, -1);
            pcp = editor.caretPosition;
        }
        Debug.Log(chr);
        */

    }
}
